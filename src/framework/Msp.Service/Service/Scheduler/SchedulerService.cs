using Msp.Entity.Entities;
using Msp.Models.Models.Scheduler;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Scheduler
{
    public class SchedulerService : BaseService
    {


        #region scheduler
        public List<AppointmentsDTO> GetListAppointments()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Appointments>, List<AppointmentsDTO>>(_db.Appointments.ToList());
            }
        }
        public List<ResourcesDTO> GetListResources()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Resources>, List<ResourcesDTO>>(_db.Resources.ToList());
            }
        }

        public ActionResponse<List<AppointmentsDTO>> SaveAppointments(List<AppointmentsDTO> model)
        {
            ActionResponse<List<AppointmentsDTO>> response = new ActionResponse<List<AppointmentsDTO>>()
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
                        if (item.UniqueID == 0)
                        {
                            _db.Appointments.Add(base.Map<AppointmentsDTO, Appointments>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.Appointments.FirstOrDefault(x => x.UniqueID == item.UniqueID);
                            if (entity != null)
                            {
                                base.SetLog<Appointments, AppointmentsDTO>(entity, item, _db, item.UniqueID);
                                _db.Entry(entity).CurrentValues.SetValues(model);
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

        #endregion


    }
}
