using Msp.Entity.Entities;
using Msp.Models.Models.Order;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Order
{
    public class OrderService : BaseService
    {
        public List<OrderOwnerDTO> GetList_Order(int invoiceType)
        {
            using (var _db = new MspDbContext())
            {
                List<OrderOwnerDTO> result = new List<OrderOwnerDTO>();
                if (invoiceType == 3)
                {
                    result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.OrderType == 1 || x.OrderType == 2).ToList());
                }
                else
                {
                    result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.OrderType == invoiceType).ToList());
                }
                return result;
            }
        }

        public ActionResponse<OrderRequest> Save_Orders(OrderRequest model)
        {
            ActionResponse<OrderRequest> response = new ActionResponse<OrderRequest>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                using (DbContextTransaction transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        int OrderOwnerId = 0;
                        if (response.Response.OrderOwner.RecId == 0)
                        {
                            OrderOwner orderOwner = base.Map<OrderOwnerDTO, OrderOwner>(model.OrderOwner);
                            _db.OrderOwner.Add(orderOwner);
                            _db.SaveChanges();
                            OrderOwnerId = orderOwner.RecId;
                        }
                        else
                        {
                            var entity = _db.OrderOwner.FirstOrDefault(x => x.RecId == response.Response.OrderOwner.RecId);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(model.OrderOwner);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
                        }


                        foreach (var item in model.OrderTrans)
                        {
                            if (item.RecId == 0)
                            {
                                item.OwnerId = OrderOwnerId;
                                _db.OrderTrans.Add(base.Map<OrderTransDTO, OrderTrans>(item));
                                //var product = _db.products.FirstOrDefault(x => x.PID == item.ProductId);
                                //if (product != null)
                                //{
                                //    Products updatePro = new Products();
                                //    updatePro = product;
                                //    updatePro.PTotal = updatePro.PTotal - item.ProductQuantity;
                                //    _db.Entry(product).CurrentValues.SetValues(updatePro);
                                //    _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                                //}
                            }
                            else
                            {
                                var entity = _db.OrderTrans.FirstOrDefault(x => x.RecId == item.RecId);
                                if (entity != null)
                                {
                                    _db.Entry(entity).CurrentValues.SetValues(item);
                                    _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                                }
                            }
                        }
                        _db.SaveChanges();
                        transaction.Commit();

                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        response.Message = e.ToString();
                        response.ResponseType = ResponseType.Error;
                    }
                }
            }
            return response;
        }






    }
}
