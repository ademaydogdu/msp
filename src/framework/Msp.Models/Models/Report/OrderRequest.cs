using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Report
{
    public class OrderRequest
    {
        public int OrderType { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate
        {
            get; set;
        }
    }
}
