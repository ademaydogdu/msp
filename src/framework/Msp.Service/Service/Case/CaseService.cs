using Msp.Entity.Entities;
using Msp.Models.Models.Case;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Case
{
    public class CaseService : BaseService
    {

        #region CaseMovement
        public List<CaseMovementDTO> Get_List_CaseMovement(int companyId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CaseMovement>, List<CaseMovementDTO>>(_db.CaseMovement.Where(x => x.Deleted == false && x.CompanyRecId == companyId).ToList());
            }
        }

        public List<CaseMovementDTO> Get_List_CaseMovement_Date(int companyId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CaseMovement>, List<CaseMovementDTO>>(_db.CaseMovement.Where(x => x.Deleted == false && x.CompanyRecId == companyId && EntityFunctions.TruncateTime(x.RecordDate) == DateTime.Today).ToList());
            }
        }

        public CaseMovementDTO Get_CaseMovement(int recId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<CaseMovement, CaseMovementDTO>(_db.CaseMovement.Where(x => x.RecId == recId).FirstOrDefault());
            }
        }

        public ActionResponse<CaseMovementDTO> SaveCaseMovement(CaseMovementDTO model)
        {
            ActionResponse<CaseMovementDTO> response = new ActionResponse<CaseMovementDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (model.RecId == 0)
                    {
                        _db.CaseMovement.Add(base.Map<CaseMovementDTO, CaseMovement>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.CaseMovement.FirstOrDefault(x => x.RecId == response.Response.RecId);
                        if (entity != null)
                        {
                            base.SetLog(entity, model, _db, response.Response.RecId);
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


        public ActionResponse<CaseMovementDTO> Delete_Case(CaseMovementDTO model)
        {
            ActionResponse<CaseMovementDTO> response = new ActionResponse<CaseMovementDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                var SAleControl = _db.SaleOwner.FirstOrDefault(x => x.RecId == response.Response.SaleOwnerId);
                if (SAleControl != null)
                {
                    response.ResponseType = ResponseType.Error;
                    response.Message = "Satış Yapılmış Kayıttır. Silinemez.";
                    return response;
                }
                var entity = _db.CaseMovement.Where(x => x.RecId == response.Response.RecId).FirstOrDefault();
                if (entity != null)
                {
                    entity.Deleted = true;
                    _db.Entry(entity).CurrentValues.SetValues(model);
                    _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                }
                _db.SaveChanges();
            }
            return response;
        }
        #endregion




    }
}
