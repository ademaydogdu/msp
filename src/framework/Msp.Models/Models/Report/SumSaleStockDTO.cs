using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report
{
    public class SumSaleStockDTO
    {
        public string PCode { get; set; }
        public string PName { get; set; }
        public int SatilanMiktar { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
