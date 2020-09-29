using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Sale
{
    public class SaleRequest
    {
        public SaleOwnerDTO SaleOwnerDTO { get; set; }
        public List<SaleTransDTO> List_SaleTrans { get; set; }
    }
}
