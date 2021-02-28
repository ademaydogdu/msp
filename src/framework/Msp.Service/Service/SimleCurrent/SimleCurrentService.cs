using Msp.Entity.Entities;
using Msp.Models.Models.Utilities;
using Msp.Models.SimleCurrentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.SimleCurrent
{
    public class SimleCurrentService : BaseService
    {

        public List<SimleCurrentDefinitionDTO> GetList_SimleCurrentDefinition()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<SimleCurrentDefinition>, List<SimleCurrentDefinitionDTO>>(_db.SimleCurrentDefinition.ToList());
            }
        }


        public SimleCurrentDefinitionDTO Get_SimleCurrentDefinition(int RecId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<SimleCurrentDefinition, SimleCurrentDefinitionDTO>(_db.SimleCurrentDefinition.FirstOrDefault(x => x.RecId == RecId));
            }
        }

        public ActionResponse<SimleCurrentDefinitionDTO> Save_SimleCurrentDefinition(SimleCurrentDefinitionDTO model)
        {
            ActionResponse<SimleCurrentDefinitionDTO> response = new ActionResponse<SimleCurrentDefinitionDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.RecId == 0)
                    {
                        _db.SimleCurrentDefinition.Add(base.Map<SimleCurrentDefinitionDTO, SimleCurrentDefinition>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.SimleCurrentDefinition.FirstOrDefault(x => x.RecId == response.Response.RecId);
                        if (entity != null)
                        {
                            base.SetLog<SimleCurrentDefinition, SimleCurrentDefinitionDTO>(entity, model, _db, response.Response.RecId);
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


        #region InvoiceOwner

        public ActionResponse<SimpleInvoiceOwnerDTO> Save_SimpleInvoiceOwner_Easy(SimpleInvoiceOwnerDTO model)
        {
            ActionResponse<SimpleInvoiceOwnerDTO> response = new ActionResponse<SimpleInvoiceOwnerDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.RecId == 0)
                    {
                        _db.SimpleInvoiceOwner.Add(base.Map<SimpleInvoiceOwnerDTO, SimpleInvoiceOwner>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.SimpleInvoiceOwner.FirstOrDefault(x => x.RecId == response.Response.RecId);
                        if (entity != null)
                        {
                            base.SetLog<SimpleInvoiceOwner, SimpleInvoiceOwnerDTO>(entity, model, _db, response.Response.RecId);
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

        #endregion

    }
}
