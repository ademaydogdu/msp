using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report
{
    public class KDVReportDto
    {
        public int KDV { get; set; }
        public decimal? AlisMatrah { get; set; }
        public decimal? SatisMatrah { get; set; }
        public decimal? AlisKDV { get; set; }
        public decimal? SatisKDV { get; set; }
        public decimal? Farki { get; set; }
    }
}
