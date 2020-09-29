using Msp.Entity.Entities;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Sale
{
    public class SaleService : BaseService
    {
        #region Sale
        public ActionResponse<SaleRequest> Save_Sale(SaleRequest model)
        {
            ActionResponse<SaleRequest> response = new ActionResponse<SaleRequest>()
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
                        if (response.Response.SaleOwnerDTO.RecId == 0)
                        {
                            SaleOwner saleOwner = base.Map<SaleOwnerDTO, SaleOwner>(model.SaleOwnerDTO);
                            _db.SaleOwner.Add(saleOwner);
                            _db.SaveChanges();
                            saleOwnerId = saleOwner.RecId;
                        }
                        else
                        {
                            var entity = _db.SaleOwner.FirstOrDefault(x => x.RecId == response.Response.SaleOwnerDTO.RecId);
                            if (entity != null)
                            {
                                _db.Entry(entity).CurrentValues.SetValues(model.SaleOwnerDTO);
                                _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                            }
                        }
                        

                        foreach (var item in model.List_SaleTrans)
                        {
                            if (item.RecId == 0)
                            {
                                item.SaleOwnerId = saleOwnerId;
                                _db.SaleTrans.Add(base.Map<SaleTransDTO, SaleTrans>(item));
                            }
                            else
                            {
                                var entity = _db.SaleTrans.FirstOrDefault(x => x.RecId == item.RecId);
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

        #endregion
    }
}
