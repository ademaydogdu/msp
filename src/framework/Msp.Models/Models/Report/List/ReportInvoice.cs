using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report.List
{
    public class ReportInvoice
    {
        public DateTime FichDate { get; set; }
        public string FaturaNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public int InvoiceType { get; set; }

        public List<ReportInvoiceTransDTO> trans { get; set; }
    }
}
