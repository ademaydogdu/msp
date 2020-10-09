using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("SaleOwner")]
    public class SaleOwner
    {
        [Key]
        public int RecId { get; set; }
        public DateTime? Date { get; set; }
        public string CustomerName { get; set; }
        public int? PaymentType { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? KDV { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string TotalPriceText { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? ReceivedPrice { get; set; }
        public string Remark { get; set; }
        public bool? Veresiye { get; set; }
        public int? CompanyRecId { get; set; }
        public bool? Deleted { get; set; }
        public string UserCode { get; set; }


    }
}
