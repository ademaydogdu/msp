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
        #region Order

        public List<OrderOwnerDTO> GetList_Order(int invoiceType)
        {
            using (var _db = new MspDbContext())
            {
                List<OrderOwnerDTO> result = new List<OrderOwnerDTO>();
                if (invoiceType == 3)
                {
                    result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.OrderType == 1 || x.OrderType == 2 && x.Deleted == false).ToList());
                }
                else if (invoiceType == 4)
                {
                    result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.IrsaliyeId == 0 && x.Deleted == false).ToList());
                }
                else
                {
                    result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.OrderType == invoiceType && x.Deleted == false).ToList());
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

                        if (_db.OrderOwner.Any(x => x.SiparisNo == model.OrderOwner.SiparisNo && x.Deleted == false))
                        {
                            response.Message = "Aynı Sipariş No'dan vardır.";
                            response.ResponseType = ResponseType.Error;
                            return response;
                        }


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

        public OrderOwnerDTO Get_OrderOwner(int RecId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<OrderOwner, OrderOwnerDTO>(_db.OrderOwner.Where(x => x.RecId == RecId).FirstOrDefault());
            }
        }

        public List<OrderTransDTO> Get_OrderTrans(int OwnerRecId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<OrderTrans>, List<OrderTransDTO>>(_db.OrderTrans.Where(x => x.OwnerId == OwnerRecId).ToList());
            }
        }

        public ActionResponse<OrderOwnerDTO> Deleted_Order(int orderId)
        {
            ActionResponse<OrderOwnerDTO> response = new ActionResponse<OrderOwnerDTO>()
            {
                ResponseType = ResponseType.Ok
            };

            using (MspDbContext _db = new MspDbContext())
            {
                using (DbContextTransaction transaction = _db.Database.BeginTransaction())
                {

                    try
                    {
                        var record = _db.OrderOwner.FirstOrDefault(x => x.RecId == orderId);
                        if (record != null)
                        {
                            record.Deleted = true;
                            record.SiparisNo = "";
                            _db.Entry(record).CurrentValues.SetValues(record);
                            _db.Entry(record).State = System.Data.Entity.EntityState.Modified;

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


        #endregion




    }
}
