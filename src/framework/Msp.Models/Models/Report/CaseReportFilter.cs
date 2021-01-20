using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report
{
    public class CaseReportFilter
    {
        public int companyId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CaseId { get; set; }
        public int BeginProduct { get; set; }
        public int EndProduct { get; set; }
    }
}
