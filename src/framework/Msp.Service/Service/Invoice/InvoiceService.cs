using Msp.Entity.Entities;
using Msp.Models.Models.Invoice;
using Msp.Models.Models.Order;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Invoice
{
    public class InvoiceService : BaseService
    {

        #region InvoiceEdit

        public List<InvoiceOwnerDTO> GetList_Invoice(int invoiceType)
        {
            using (var _db = new MspDbContext())
            {
                List<InvoiceOwnerDTO> result = new List<InvoiceOwnerDTO>();
                if (invoiceType == 3)
                {
                    result = base.Map<List<InvoiceOwner>, List<InvoiceOwnerDTO>>(_db.InvoiceOwner.Where(x => x.InvoiceType == 1 || x.InvoiceType == 2 && x.Deleted == false).ToList());
                }
                if (invoiceType == 6)
                {
                    result = base.Map<List<InvoiceOwner>, List<InvoiceOwnerDTO>>(_db.InvoiceOwner.Where(x => x.InvoiceType == 4 || x.InvoiceType == 5 && x.Deleted == false).ToList());
                }
                else
                {
                    result = base.Map<List<InvoiceOwner>, List<InvoiceOwnerDTO>>(_db.InvoiceOwner.Where(x => x.InvoiceType == invoiceType && x.Deleted == false).ToList());
                }
                return result;
            }
        }

        public ActionResponse<InvoiceSaveRequest> Save_Inovice(InvoiceSaveRequest model)
        {
            ActionResponse<InvoiceSaveRequest> response = new ActionResponse<InvoiceSaveRequest>()
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
                        int InvoiceOwnerRecId = 0;
                        if (response.Response.InvoiceOwner.RecId == 0)
                        {
                            InvoiceOwner invoiceOwner = base.Map<InvoiceOwnerDTO, InvoiceOwner>(model.InvoiceOwner);
                            _db.InvoiceOwner.Add(invoiceOwner);
                            _db.SaveChanges();
                            InvoiceOwnerRecId = invoiceOwner.RecId;
                        }
                        else
                        {
                            var entity = _db.InvoiceOwner.FirstOrDefault(x => x.RecId == response.Response.InvoiceOwner.RecId);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(model.InvoiceOwner);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
                        }


                        foreach (var item in model.InvoiceTrans)
                        {
                            if (item.RecId == 0)
                            {
                                item.InvoiceOwnerId = InvoiceOwnerRecId;
                                _db.InvoiceTrans.Add(base.Map<InvoiceTransDTO, InvoiceTrans>(item));
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
                                var entity = _db.InvoiceTrans.FirstOrDefault(x => x.RecId == item.RecId);
                                if (entity != null)
                                {
                                    _db.Entry(entity).CurrentValues.SetValues(item);
                                    _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                                }
                            }
                        }

                        if (model.IsOrder)
                        {
                            var order = _db.OrderOwner.FirstOrDefault(x => x.RecId == response.Response.InvoiceOwner.OrderId);
                            if (order != null)
                            {
                                order.IrsaliyeId = InvoiceOwnerRecId;
                                order.Durum = "İrsaliye Tarafında";
                                _db.Entry(order).CurrentValues.SetValues(order);
                                _db.Entry(order).State = EntityState.Modified;
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

        public ActionResponse<InvoiceOwnerDTO> Deleted_InvoiceOwner(int invoiceId)
        {
            ActionResponse<InvoiceOwnerDTO> response = new ActionResponse<InvoiceOwnerDTO>()
            {
                ResponseType = ResponseType.Ok
            };

            using (MspDbContext _db = new MspDbContext())
            {
                using (DbContextTransaction transaction = _db.Database.BeginTransaction())
                {

                    try
                    {
                        var record = _db.InvoiceOwner.FirstOrDefault(x => x.RecId == invoiceId);
                        if (record != null)
                        {
                            record.Deleted = true;
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

        #region OrderList

        public List<OrderOwnerDTO> GetList_OrderWait()
        {
            using (var _db = new MspDbContext())
            {
                List<OrderOwnerDTO> result = new List<OrderOwnerDTO>();
                result = base.Map<List<OrderOwner>, List<OrderOwnerDTO>>(_db.OrderOwner.Where(x => x.IrsaliyeId == 0 && x.Deleted == false).ToList());
                return result;
            }
        }

        public List<OrderTransDTO> Get_orderTrans_Invoice(int OwnerId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<OrderTrans>, List<OrderTransDTO>>(_db.OrderTrans.Where(x => x.OwnerId == OwnerId).ToList());
            }
        }


        #endregion

        #region Findİrsaliye
        public List<InvoiceOwnerDTO> GetList_FindIrsaliye(int invoiceType)
        {
            using (var _db = new MspDbContext())
            {
                List<InvoiceOwnerDTO> result = new List<InvoiceOwnerDTO>();
                result = base.Map<List<InvoiceOwner>, List<InvoiceOwnerDTO>>(_db.InvoiceOwner.Where(x => x.InvoiceType == 4 && x.IrsaliyeId == 0 && x.Deleted == false).ToList());
                return result;
            }
        }

        public List<InvoiceTransDTO> Get_InovicerTranse(int OwnerId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<InvoiceTrans>, List<InvoiceTransDTO>>(_db.InvoiceTrans.Where(x => x.InvoiceOwnerId == OwnerId).ToList());
            }
        }

        #endregion

    }
}
