using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Daily
{
    public class DailyTransDTO
    {
        public int RecId { get; set; }
        public int? OwnerId { get; set; }
        public int? SaleTransId { get; set; }
        public int? CaseOwnerId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public int? Type { get; set; }
        public DateTime? Date { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
