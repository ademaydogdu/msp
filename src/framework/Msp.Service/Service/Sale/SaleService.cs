using Msp.Entity.Entities;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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

        public SaleOwnerDTO Get_SaleOwner(int RecId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<SaleOwner, SaleOwnerDTO>(_db.SaleOwner.FirstOrDefault(x=>x.RecId == RecId));
            }
        }

        public List<SaleTransDTO> Get_List_SaleOwner(int RecId)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<SaleTrans>, List<SaleTransDTO>>(_db.SaleTrans.Where(x => x.SaleOwnerId == RecId).ToList());
            }
        }


        #endregion

        #region SaleList

        public List<SaleOwnerDTO> GetList_Date(DateTime date)
        {
            using (var _db = new MspDbContext())
            {
                var result = base.Map<List<SaleOwner>, List<SaleOwnerDTO>>(_db.SaleOwner.Where(x => EntityFunctions.TruncateTime(x.Date) == date).ToList());
                return result;
            }
        }

        #endregion

        #region SpeedSale
        public List<SpeedSaleProductDTO> GetList_SpeedSaleProduct()
        {
            using (var _db = new MspDbContext())
            {
                var result = base.Map<List<SpeedSaleProduct>, List<SpeedSaleProductDTO>>(_db.SpeedSaleProduct.ToList());
                return result;
            }
        }

        public ActionResponse<List<SpeedSaleProductDTO>> SaveSpeedSaleProduct(List<SpeedSaleProductDTO> model)
        {
            ActionResponse<List<SpeedSaleProductDTO>> response = new ActionResponse<List<SpeedSaleProductDTO>>()
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
                            _db.SpeedSaleProduct.Add(base.Map<SpeedSaleProductDTO, SpeedSaleProduct>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.SpeedSaleProduct.FirstOrDefault(x => x.RecId == item.RecId);
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

        public ActionResponse<SpeedSaleProductDTO> DeleteSpeedSaleProduct(int? id)
        {
            ActionResponse<SpeedSaleProductDTO> response = new ActionResponse<SpeedSaleProductDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.SpeedSaleProduct.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.SpeedSaleProduct.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion
    }
}
