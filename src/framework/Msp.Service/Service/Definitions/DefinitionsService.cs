using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Tanimlar
{
    public class DefinitionsService : BaseService
    {
        #region PaymentTypes
        public List<PaymentTypeDTO> GetListPayments()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<PaymentType>, List<PaymentTypeDTO>>(_db.PaymentTypes.ToList());
            }
        }

        #endregion

        #region CurrencyType

        public List<CurrencyTypeDTO> Get_List_CurrencyType()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CurrencyType>, List<CurrencyTypeDTO>>(_db.CurrencyType.ToList());
            }
        }

        public ActionResponse<List<CurrencyTypeDTO>> SaveCurrencyType(List<CurrencyTypeDTO> model)
        {
            ActionResponse<List<CurrencyTypeDTO>> response = new ActionResponse<List<CurrencyTypeDTO>>()
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
                            _db.CurrencyType.Add(base.Map<CurrencyTypeDTO, CurrencyType>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.CurrencyType.FirstOrDefault(x => x.RecId == item.RecId);
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

        public ActionResponse<CurrencyTypeDTO> DeleteCurrencyType(int? id)
        {
            ActionResponse<CurrencyTypeDTO> response = new ActionResponse<CurrencyTypeDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.CurrencyType.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.CurrencyType.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion

        #region ProductMarks
        public List<ProductMarkDTO> Get_List_ProductMark()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<ProductMark>, List<ProductMarkDTO>>(_db.ProductMark.ToList());
            }
        }
        public ActionResponse<List<ProductMarkDTO>> SaveProductMark(List<ProductMarkDTO> model)
        {
            ActionResponse<List<ProductMarkDTO>> response = new ActionResponse<List<ProductMarkDTO>>()
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
                            _db.ProductMark.Add(base.Map<ProductMarkDTO, ProductMark>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.ProductMark.FirstOrDefault(x => x.RecId == item.RecId);
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

        public ActionResponse<ProductMarkDTO> DeleteProductMark(int? id)
        {
            ActionResponse<ProductMarkDTO> response = new ActionResponse<ProductMarkDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.ProductMark.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.ProductMark.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion

        #region ProductGroup
        public List<ProductGroupDTO> Get_List_ProductGroup()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<ProductGroup>, List<ProductGroupDTO>>(_db.ProductGroup.ToList());
            }
        }
        public ActionResponse<List<ProductGroupDTO>> SaveProductGroup(List<ProductGroupDTO> model)
        {
            ActionResponse<List<ProductGroupDTO>> response = new ActionResponse<List<ProductGroupDTO>>()
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
                            _db.ProductGroup.Add(base.Map<ProductGroupDTO, ProductGroup>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.ProductMark.FirstOrDefault(x => x.RecId == item.RecId);
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

        public ActionResponse<ProductGroupDTO> DeleteProductGroup(int? id)
        {
            ActionResponse<ProductGroupDTO> response = new ActionResponse<ProductGroupDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.ProductGroup.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.ProductGroup.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion

        #region CashPayGroup
        public List<CashPayGroupDefDTO> Get_List_CashPayGroup()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CashPayGroupDef>, List<CashPayGroupDefDTO>>(_db.CashPayGroupDef.ToList());
            }
        }
        public ActionResponse<List<CashPayGroupDefDTO>> SaveCashPayGroupDefDTO(List<CashPayGroupDefDTO> model)
        {
            ActionResponse<List<CashPayGroupDefDTO>> response = new ActionResponse<List<CashPayGroupDefDTO>>()
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
                            _db.CashPayGroupDef.Add(base.Map<CashPayGroupDefDTO, CashPayGroupDef>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.CashPayGroupDef.FirstOrDefault(x => x.RecId == item.RecId);
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

        public ActionResponse<CashPayGroupDefDTO> DeleteCashPayGroup(int? id)
        {
            ActionResponse<CashPayGroupDefDTO> response = new ActionResponse<CashPayGroupDefDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.CashPayGroupDef.Where(x => x.RecId == id).FirstOrDefault();
                if (record != null)
                {
                    _db.CashPayGroupDef.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion

    }
}
