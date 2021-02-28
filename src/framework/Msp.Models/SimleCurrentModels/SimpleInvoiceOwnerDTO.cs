using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.SimleCurrentModels
{
    public class SimpleInvoiceOwnerDTO
    {
        public int RecId { get; set; }
        public int? CariId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? InvoiceType { get; set; }
        public string InvoiceNo { get; set; }
        public string Remark { get; set; }
        public int? Vade { get; set; } = 0;
        public decimal? Borc { get; set; } = 0;
        public decimal? Alacak { get; set; } = 0;
        public decimal? Bakiye { get; set; } 
        public decimal? CurrencyBorc { get; set; } = 0;
        public decimal? CurrencyAlacak { get; set; } = 0;
        public decimal? CurrencyBakiye { get; set; }
        public bool? IsDetail { get; set; }
        public int? CurrencyId { get; set; }
        public bool? Deleted { get; set; } = false;
    }
}
