using Msp.Entity.Entities;
using Msp.Models.Models.Daily;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Daily
{
    public class DailyService : BaseService
    {



        public List<DailyOwnerDTO> Get_List_DailyOwner()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<DailyOwner>, List<DailyOwnerDTO>>(_db.DailyOwner.Where(x => x.Deleted == false).ToList());
            }
        }

        #region DailyServi

        public List<DailyOwnerDTO> Get_List_DailyOwner_Control()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<DailyOwner>, List<DailyOwnerDTO>>(_db.DailyOwner.Where(x => x.Deleted == false && EntityFunctions.TruncateTime(x.Date) == DateTime.Today).ToList());
            }
        }

        public ActionResponse<DailyRequest> Save_Daily(DailyRequest model)
        {
            ActionResponse<DailyRequest> response = new ActionResponse<DailyRequest>()
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
                        int saleOwnerId = 0;
                        if (response.Response.dailyOwner.RecId == 0)
                        {
                            DailyOwner dailyOwner = base.Map<DailyOwnerDTO, DailyOwner>(model.dailyOwner);
                            _db.DailyOwner.Add(dailyOwner);
                            _db.SaveChanges();
                            saleOwnerId = dailyOwner.RecId;
                        }
                        else
                        {
                            var entity = _db.DailyOwner.FirstOrDefault(x => x.RecId == response.Response.dailyOwner.RecId);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(model.dailyOwner);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
                        }


                        foreach (var item in model.dailyTrans)
                        {
                            if (item.RecId == 0)
                            {
                                item.OwnerId = saleOwnerId;
                                _db.DailyTrans.Add(base.Map<DailyTransDTO, DailyTrans>(item));
                            }
                            else
                            {
                                var entity = _db.DailyTrans.FirstOrDefault(x => x.RecId == item.RecId);
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

        public ActionResponse<DailyOwnerDTO> Delete_Daily(DailyOwnerDTO model)
        {
            ActionResponse<DailyOwnerDTO> response = new ActionResponse<DailyOwnerDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {

                try
                {
                    var recordOwner = _db.DailyOwner.FirstOrDefault(x => x.RecId == model.RecId);
                    if (recordOwner != null)
                    {
                        _db.DailyOwner.Remove(recordOwner);
                    }
                    var recordTrans = _db.DailyTrans.Where(x => x.OwnerId == model.RecId).ToList();
                    if (recordTrans.Count > 0)
                    {
                        _db.DailyTrans.RemoveRange(recordTrans);
                    }
                    _db.SaveChanges();
                    response.ResponseType = ResponseType.Ok;
                }
                catch (Exception ex)
                {
                    response.ResponseType = ResponseType.Error;
                    response.Message = ex.Message;
                }

            }
            return response;
        }

        #endregion




    }
}
