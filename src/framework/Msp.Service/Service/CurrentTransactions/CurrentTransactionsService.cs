using Msp.Entity.Entities;
using Msp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.CurrentTransactions
{
   public class CurrentTransactionsService : BaseService
    {

        public List<CTransactionsDTO> GetCurrentTransactions()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CTransactions>, List<CTransactionsDTO>>(_db.CurrentTransactions.ToList());
            }
        }


        public CTransactionsDTO GetCurrentTransactions(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<CTransactions, CTransactionsDTO>(_db.CurrentTransactions.FirstOrDefault(x => x.CurId == id));
            }
        }


    }


}

