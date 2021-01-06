using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Product
{
    public class ProductPrintRequest
    {
        public int ProductBegin { get; set; }
        public int ProductEnd { get; set; }
        public int companyId { get; set; }
        public int DepotId { get; set; }
    }
}
