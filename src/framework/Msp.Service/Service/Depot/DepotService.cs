using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Depot
{
    public class DepotService : BaseService
    {

        #region Depots

        public List<DepotDTO> GetListDepot()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Depots>, List<DepotDTO>>(_db.Depot.ToList());
            }
        }

        public DepotDTO GetDepot(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Depots, DepotDTO>(_db.Depot.FirstOrDefault(x => x.DID == id));
            }
        }

        public ActionResponse<DepotDTO> InsertDepot(DepotDTO model)
        {
            ActionResponse<DepotDTO> response = new ActionResponse<DepotDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };

            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.DID == 0)
                    {
                        _db.Depot.Add(base.Map<DepotDTO, Depots>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Depot.FirstOrDefault(x => x.DID == response.Response.DID);
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


        public ActionResponse<DepotDTO> SaveDepot(DepotDTO model)
        {
            ActionResponse<DepotDTO> response = new ActionResponse<DepotDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.DID == 0)
                    {
                        _db.Depot.Add(base.Map<DepotDTO, Depots>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Depot.FirstOrDefault(x => x.DID == response.Response.DID);
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

        public ActionResponse<DepotDTO> DeleteDepot(int? DID)
        {
            ActionResponse<DepotDTO> response = new ActionResponse<DepotDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.Depot.Where(x => x.DID == DID).FirstOrDefault();
                if (record != null)
                {
                    _db.Depot.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion
    }
}
