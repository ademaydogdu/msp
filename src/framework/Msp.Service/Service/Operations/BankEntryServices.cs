using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Operations
{
    public class BankEntryServices : BaseService
    {
        public List<BankEntryDTO> GetListBankEntries()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<BankEntry>, List<BankEntryDTO>>(_db.BankEntry.ToList());
            }
        }

        public BankEntryDTO GetBankEntries(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<BankEntry, BankEntryDTO>(_db.BankEntry.FirstOrDefault(x => x.bid == id));
            }
        }


        public ActionResponse<BankEntryDTO> InsertBankEntries(BankEntryDTO model)
        {
            ActionResponse<BankEntryDTO> response = new ActionResponse<BankEntryDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.bid == 0)
                    {
                        _db.BankEntry.Add(base.Map<BankEntryDTO, BankEntry>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.BankEntry.FirstOrDefault(x => x.bid == response.Response.bid);
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


        public ActionResponse<BankEntryDTO> SaveBankEntries(BankEntryDTO model)
        {
            ActionResponse<BankEntryDTO> response = new ActionResponse<BankEntryDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.bid == 0)
                    {
                        _db.BankEntry.Add(base.Map<BankEntryDTO, BankEntry>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.products.FirstOrDefault(x => x.PID == response.Response.bid);
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

        public ActionResponse<BankEntryDTO> DeleteBankEntries(int? bid)
        {
            ActionResponse<BankEntryDTO> response = new ActionResponse<BankEntryDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.BankEntry.Where(x => x.bid == bid).FirstOrDefault();
                if (record != null)
                {
                    _db.BankEntry.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #region Banks

        public List<BanksDTO> GetListBanks()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Banks>, List<BanksDTO>>(_db.Banks.ToList());
            }
        }


        public ActionResponse<BanksDTO> InsertBank(BanksDTO model)
        {
            ActionResponse<BanksDTO> response = new ActionResponse<BanksDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.Bid == 0)
                    {
                        _db.Banks.Add(base.Map<BanksDTO, Banks>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Banks.FirstOrDefault(x => x.Bid == response.Response.Bid);
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

        public ActionResponse<List<BanksDTO>> SaveBank(List<BanksDTO> model)
        {
            ActionResponse<List<BanksDTO>> response = new ActionResponse<List<BanksDTO>>()
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
                        if (item.Bid == 0)
                        {
                            _db.Banks.Add(base.Map<BanksDTO, Banks>(item));
                            _db.SaveChanges();
                        }
                        else
                        {
                            var entity = _db.Banks.FirstOrDefault(x => x.Bid == item.Bid);
                            if (entity != null)
                            {
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

        public ActionResponse<BanksDTO> DeleteBank(int? id)
        {
            ActionResponse<BanksDTO> response = new ActionResponse<BanksDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.Banks.Where(x => x.Bid == id).FirstOrDefault();
                if (record != null)
                {
                    _db.Banks.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }

        #endregion


    }
}
