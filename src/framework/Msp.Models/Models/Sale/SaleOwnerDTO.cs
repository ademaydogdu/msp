using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Sale
{
    public class SaleOwnerDTO
    {
        public int RecId { get; set; }
        public DateTime? Date { get; set; }
        public string CustomerName { get; set; }
        public string PaymentType { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? KDV { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? ReceivedPrice { get; set; }
        public string Remark { get; set; }
        public bool? Veresiye { get; set; }
    }
}
