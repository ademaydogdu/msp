using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.DepotStock
{
    public class DepotStockService : BaseService
    {
        #region Product
        public List<ProductDTO> GetListProduct()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Products>, List<ProductDTO>>(_db.products.ToList());
            }
        }
        public ProductDTO GetProduct(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Products, ProductDTO>(_db.products.FirstOrDefault(x => x.PID == id));
            }
        }




        public ActionResponse<ProductDTO> InsertProduct(ProductDTO model)
        {
            ActionResponse<ProductDTO> response = new ActionResponse<ProductDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.PID == 0)
                    {
                        _db.products.Add(base.Map<ProductDTO, Products>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.products.FirstOrDefault(x => x.PID == response.Response.PID);
                        if (entity != null)
                        {
                            _db.Entry(entity).CurrentValues.SetValues(entity);
                            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        public ActionResponse<ProductDTO> SaveProduct(ProductDTO model)
        {
            ActionResponse<ProductDTO> response = new ActionResponse<ProductDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.PID == 0)
                    {
                        _db.products.Add(base.Map<ProductDTO, Products>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.products.FirstOrDefault(x => x.PID == response.Response.PID);
                        if (entity != null)
                        {
                            _db.Entry(entity).CurrentValues.SetValues(model);
                            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        public ActionResponse<ProductDTO> DeleteProduct(int? PID)
        {
            ActionResponse<ProductDTO> response = new ActionResponse<ProductDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.products.Where(x => x.PID == PID).FirstOrDefault();
                if (record != null)
                {
                    _db.products.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion

        #region Product Expiry Day

        public List<ProductDTO> GetListExpDateProducts()
        {
            
            DateTime endDate = DateTime.Now;
            using (var _db = new MspDbContext())
            {               
               return base.Map<List<Products>,  List<ProductDTO>>(_db.products.Where(x => EntityFunctions.TruncateTime(x.PExpDate) <= endDate).ToList());  
            }
        }

        #endregion



        #region Unit

        public List<UnitsDTO> GetListUnit()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Units>, List<UnitsDTO>>(_db.Units.ToList());
            }
        }

        public ActionResponse<List<UnitsDTO>> SaveUnit(List<UnitsDTO> model)
        {
            ActionResponse<List<UnitsDTO>> response = new ActionResponse<List<UnitsDTO>>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    foreach (var item in model)
                    {
                        if (item.UID == 0)
                        {
                            _db.Units.Add(base.Map<UnitsDTO, Units>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.Units.FirstOrDefault(x => x.UID == item.UID);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(item);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
                        } 
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        public ActionResponse<UnitsDTO> DeleteUnit(int? id)
        {
            ActionResponse<UnitsDTO> response = new ActionResponse<UnitsDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.Units.Where(x => x.UID == id).FirstOrDefault();
                if (record != null)
                {
                    _db.Units.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion

        #region Payment

        public List<PaymentTypeDTO> Get_List_Payment()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<PaymentType>, List<PaymentTypeDTO>>(_db.PaymentTypes.ToList());
            }
        }

        public ActionResponse<List<PaymentTypeDTO>> SavePayment(List<PaymentTypeDTO> model)
        {
            ActionResponse<List<PaymentTypeDTO>> response = new ActionResponse<List<PaymentTypeDTO>>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    foreach (var item in model)
                    {
                        if (item.RecId == 0)
                        {
                            _db.PaymentTypes.Add(base.Map<PaymentTypeDTO, PaymentType>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.PaymentTypes.FirstOrDefault(x => x.RecId == item.RecId);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(item);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
                        }
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        public ActionResponse<PaymentTypeDTO> DeletePayment(int? id)
        {
            ActionResponse<PaymentTypeDTO> response = new ActionResponse<PaymentTypeDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.PaymentTypes.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.PaymentTypes.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion

    }
}
