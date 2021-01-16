using Msp.Entity.Entities;
using Msp.Models.Models.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Dashboard
{
    public class DashboardService : BaseService
    {

        public List<SaleOwnerDTO> GetList_SaleOwner()
        {
            using (var _db = new MspDbContext())
            {
                var result = base.Map<List<SaleOwner>, List<SaleOwnerDTO>>(_db.SaleOwner.Where(x=>x.Deleted != true && x.Date == DateTime.Now).ToList());
                return result;
            }
        }


    }

}
