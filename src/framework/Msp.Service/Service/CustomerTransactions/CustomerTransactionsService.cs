using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.CustomerTransactions
{
   public class CustomerTransactionsService : BaseService
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

        public ActionResponse<CustomersDTO> InserCustomers(CustomersDTO model)
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


        #endregion
    }
}
