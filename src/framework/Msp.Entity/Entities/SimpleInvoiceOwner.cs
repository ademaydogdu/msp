using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("SimpleInvoiceOwner")]
    public class SimpleInvoiceOwner
    {
        [Key]
        public int RecId { get; set; }
        public int? CariId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? InvoiceType { get; set; }
        public string InvoiceNo { get; set; }
        public string Remark { get; set; }
        public int? Vade { get; set; }
        public decimal? Borc { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Bakiye { get; set; }
        public decimal? CurrencyBorc { get; set; }
        public decimal? CurrencyAlacak { get; set; }
        public decimal? CurrencyBakiye { get; set; }
        public bool? IsDetail { get; set; }
        public int? CurrencyId { get; set; }
        public bool? Deleted { get; set; }

    }
}
