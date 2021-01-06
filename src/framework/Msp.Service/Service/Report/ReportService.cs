using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Report
{
    public class ReportService : BaseService
    {

        #region EnvanterBilgi
        public List<ProductDTO> Get_List_EnvanterBilgisi(ProductPrintRequest req)
        {
            using (var _db = new MspDbContext())
            {
                List<ProductDTO> products = new List<ProductDTO>();
                products = base.Map<List<Products>, List<ProductDTO>>(_db.products.Where(x => x.PID >= req.ProductBegin && x.PID <= req.ProductEnd).ToList());
                if (req.DepotId != 0)
                {
                    products = products.Where(x => x.PDepotId == req.DepotId).ToList();
                }
                if (req.companyId != 0)
                {
                    products = products.Where(x => x.PCompanyId == req.companyId).ToList();
                }
                return products;
            }
        }
        #endregion

        #region Sale




        #endregion
    }
}
