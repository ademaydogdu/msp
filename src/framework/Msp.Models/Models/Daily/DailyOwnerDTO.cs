using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Daily
{
    public class DailyOwnerDTO
    {
        public int RecId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public decimal? SaleAmount { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? CardAmount { get; set; }
        public int? TotalProduct { get; set; }
        public string Remark { get; set; }
        public int? RetailSaleCount { get; set; }
        public decimal? RetailSaleAmount { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Expense { get; set; }
        public int? CompanyRecId { get; set; }
        public bool? Deleted { get; set; }
    }
}
