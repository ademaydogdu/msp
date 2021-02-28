using Msp.Entity.Entities;
using Msp.Models.Models.Dashboard;
using Msp.Models.Models.Sale;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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
                var result = base.Map<List<SaleOwner>, List<SaleOwnerDTO>>(_db.SaleOwner.Where(x => x.Deleted != true && EntityFunctions.TruncateTime(x.Date) == DateTime.Today).ToList());
                return result;
            }
        }

        public List<SaleWeekListDTO> GetList_WeekSaleOwner()
        {
            using (var _db = new MspDbContext())
            {
                string sql = "Select CONVERT(date, Date, 120) as Date,SUM(TotalPrice) as ToplamTutar from SaleOwner  Where Date BETWEEN DATEADD(DAY, -7, GETDATE()) AND DATEADD(DAY, 1, GETDATE()) "
                                + " group by CONVERT(date, Date, 120)";
                var result = _db.Database.SqlQuery<SaleWeekListDTO>(sql).ToList();
                return result;
            }
        }



    }

}
