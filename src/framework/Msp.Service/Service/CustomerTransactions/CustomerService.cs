using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Customer;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.CustomerTransactions
{
    public class CustomerService : BaseService
    {

        #region Customers
        public List<CustomersDTO> GetListCustomer()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Customers>, List<CustomersDTO>>(_db.customers.ToList());
            }
        }
        public CustomersDTO GetCustomer(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Customers, CustomersDTO>(_db.customers.FirstOrDefault(x => x.id == id));
            }
        }

        public ActionResponse<CustomersDTO> InsertCustomers(CustomersDTO model)
        {
            ActionResponse<CustomersDTO> response = new ActionResponse<CustomersDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.id == 0)
                    {
                        _db.customers.Add(base.Map<CustomersDTO, Customers>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.customers.FirstOrDefault(x => x.id == response.Response.id);
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

        public ActionResponse<CustomersDTO> SaveCustomers(CustomersDTO model)
        {
            ActionResponse<CustomersDTO> response = new ActionResponse<CustomersDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.id == 0)
                    {
                        _db.customers.Add(base.Map<CustomersDTO, Customers>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.customers.FirstOrDefault(x => x.id == response.Response.id);
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

        public ActionResponse<CustomersDTO> DeleteCostumers(int? id)
        {
            ActionResponse<CustomersDTO> response = new ActionResponse<CustomersDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.customers.Where(x => x.id == id).FirstOrDefault();
                if (record != null)
                {
                    _db.customers.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        public ActionResponse<SaleOwnerDTO> Update_Veresiye(SaleOwnerDTO model)
        {
            ActionResponse<SaleOwnerDTO> response = new ActionResponse<SaleOwnerDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    var entity = _db.SaleOwner.FirstOrDefault(x => x.RecId == response.Response.RecId);
                    if (entity != null)
                    {
                        if (model.TotalPrice == 0)
                        {
                            model.Veresiye = false;
                            model.VeresiyeClosedDate = DateTime.Now;
                        }
                        _db.Entry(entity).CurrentValues.SetValues(model);
                        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
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


        public ActionResponse<SaleOwnerDTO> UpdateBakiyeAdd(CustomerBakiyeAddFilter result)
        {
            ActionResponse<SaleOwnerDTO> response = new ActionResponse<SaleOwnerDTO>()
            {
                Response = result._saleOwner,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {

                if (result._saleOwner.RecId > 0)
                {
                    SaleTrans _trans = new SaleTrans()
                    {
                        SaleOwnerId = result._saleOwner.RecId,
                        ProductId = 0,
                        ProductName = "Elden Veresiye - " + DateTime.Today,
                        UnitId = 0,
                        Deleted = false,
                        CaseId = result._saleOwner.CaseId,
                        ProductBarcode = "",
                        ProductQuantity = 1,
                        ProductAmount = result.Amount,
                        ProductPrice = 0,
                        ProductDate = new DateTime(1900, 1, 1),       
                        
                    };
                    _db.SaleTrans.Add(_trans);
                    _db.SaveChanges();

                    var entity = _db.SaleOwner.FirstOrDefault(x => x.RecId == result._saleOwner.RecId);
                    if (entity != null)
                    {
                        var trans = _db.SaleTrans.Where(x => x.SaleOwnerId == result._saleOwner.RecId).ToList();
                        result._saleOwner.TotalPrice = trans.Sum(x => x.ProductAmount).GetValueOrDefault();
                        result._saleOwner.TotalPriceText = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", trans.Sum(x => x.ProductAmount).GetValueOrDefault());
                        result._saleOwner.NetPrice = trans.Sum(x => x.ProductAmount).GetValueOrDefault();

                        _db.Entry(entity).CurrentValues.SetValues(result._saleOwner);
                        _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        _db.SaveChanges();
                    }

                }

            }

            return response;
        }


        #endregion
    }
}
