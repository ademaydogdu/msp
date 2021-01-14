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
        public int? PaymentType { get; set; }
        public decimal? NetPrice { get; set; }
        public string NetPriceText { get; set; } = "₺ 0.00";
        public decimal? KDV { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string TotalPriceText { get; set; } = "₺ 0.00";
        public decimal? TotalPrice { get; set; }
        public decimal? ReceivedPrice { get; set; }
        public string Remark { get; set; }
        public bool? Veresiye { get; set; }
        public int? CompanyRecId { get; set; }
        public bool? Deleted { get; set; } = false;
        public string UserCode { get; set; }
        public decimal? AlinanPrice { get; set; } = 0;
        public int? CaseId { get; set; }
        public DateTime? VeresiyeClosedDate { get; set; }




    }
}
