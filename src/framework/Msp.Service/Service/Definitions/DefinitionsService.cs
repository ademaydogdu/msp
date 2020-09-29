using Msp.Entity.Entities;
using Msp.Models.Models;
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

    }
}
