using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report
{
    public class StockBakiyeReportDTO
    {
        public int PID { get; set; }
        public int? PDepotId { get; set; }
        public string PName { get; set; }
        public decimal? PTotal { get; set; }
        public int? PUnitId { get; set; }
        public decimal? TGiren { get; set; }
        public decimal? TCikis { get; set; }
    }
}
