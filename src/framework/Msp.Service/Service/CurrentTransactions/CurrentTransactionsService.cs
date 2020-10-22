using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.CurrentTransactions
{
   public class CurrentTransactionsService : BaseService
    {

        public List<CTransactionsDTO> GetListCurrentTransactions()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CTransactions>, List<CTransactionsDTO>>(_db.CurrentTransactions.ToList());
            }
        }


        public CTransactionsDTO GetCurrentTransaction(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<CTransactions, CTransactionsDTO>(_db.CurrentTransactions.FirstOrDefault(x => x.CurID == id));
            }
        }

        public ActionResponse<CTransactionsDTO> InsertCurrentCustomer(CTransactionsDTO model)
        {
            ActionResponse<CTransactionsDTO> response = new ActionResponse<CTransactionsDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.CurID == 0)
                    {
                        _db.CurrentTransactions.Add(base.Map<CTransactionsDTO, CTransactions>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.CurrentTransactions.FirstOrDefault(x => x.CurID == response.Response.CurID);
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

        public ActionResponse<CTransactionsDTO> SaveCurrrentCustomer(CTransactionsDTO model)
        {
            ActionResponse<CTransactionsDTO> response = new ActionResponse<CTransactionsDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (MspDbContext _db = new MspDbContext())
            {
                try
                {
                    if (response.Response.CurID == 0)
                    {
                        _db.CurrentTransactions.Add(base.Map<CTransactionsDTO, CTransactions>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.CurrentTransactions.FirstOrDefault(x => x.CurID == response.Response.CurID);
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

        public ActionResponse<CTransactionsDTO> DeleteCurrentCustomer(int? PID)
        {
            ActionResponse<CTransactionsDTO> response = new ActionResponse<CTransactionsDTO>();
            using (MspDbContext _db = new MspDbContext())
            {
                var record = _db.CurrentTransactions.Where(x => x.CurID == PID).FirstOrDefault();
                if (record != null)
                {
                    _db.CurrentTransactions.Remove(record);
                }

                _db.SaveChanges();
            }
            return response;
        }




    }


}

