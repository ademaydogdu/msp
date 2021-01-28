using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class SaleBarcodCreateDTO
    {
        public int RecId { get; set; }
        public int Type { get; set; }
        public string Barcode { get; set; }
    }
}
