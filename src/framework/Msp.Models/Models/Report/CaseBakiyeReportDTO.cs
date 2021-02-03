using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report
{
    public class CaseBakiyeReportDTO
    {
        public decimal? DonemGelir { get; set; }
        public decimal? DonemGider { get; set; }
        public decimal? SonBakiye { get; set; }
        public string CaseName { get; set; }
    }
}
