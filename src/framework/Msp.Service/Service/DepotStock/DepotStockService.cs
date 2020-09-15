using Msp.Entity.Entities;
using Msp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.DepotStock
{
    public class DepotStockService : BaseService
    {
        public List<ProductDTO> GetListProduct()
        {
            using (var _db=new MspDbContext())
            {
                return base.Map<List<Products>, List<ProductDTO>>(_db.products.ToList());
            }
        }


        public ProductDTO GetProduct(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<Products,ProductDTO>(_db.products.FirstOrDefault(x=>x.PID==id));
            }
        }


        #region Unit
        public List<UnitsDTO> GetListUnit()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Units>, List<UnitsDTO>>(_db.Units.ToList());
            }
        }
        #endregion

    }
}
