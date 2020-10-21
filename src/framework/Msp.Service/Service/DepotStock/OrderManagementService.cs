using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.DepotStock
{
   public class OrderManagementService : BaseService
    {

        public List<OrderManagementDTO> GetListOrders()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<OrderManagement>, List<OrderManagementDTO>>(_db.OrderManagement.ToList());
            }
        }

        public OrderManagementDTO GetOrder(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<OrderManagement, OrderManagementDTO>(_db.OrderManagement.FirstOrDefault(x => x.oid == id));
            }
        }

        public ActionResponse<OrderManagementDTO> InsertOrder(OrderManagementDTO model)
        {
            ActionResponse<OrderManagementDTO> response = new ActionResponse<OrderManagementDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.oid == 0)
                    {
                        _db.OrderManagement.Add(base.Map<OrderManagementDTO, OrderManagement>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.OrderManagement.FirstOrDefault(x => x.oid == response.Response.oid);
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

        public ActionResponse<OrderManagementDTO> SaveOrder(OrderManagementDTO model)
        {
            ActionResponse<OrderManagementDTO> response = new ActionResponse<OrderManagementDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.oid == 0)
                    {
                        _db.OrderManagement.Add(base.Map<OrderManagementDTO, OrderManagement>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.OrderManagement.FirstOrDefault(x => x.oid == response.Response.oid);
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

    }
}
