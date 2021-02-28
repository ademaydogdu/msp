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
        public int? Vade { get; set; }
        public decimal? Borc { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Bakiye { get; set; }
        public decimal? CurrencyBorc { get; set; }
        public decimal? CurrencyAlacak { get; set; }
        public decimal? CurrencyBakiye { get; set; }
        public bool? IsDetail { get; set; }
        public int? CurrencyId { get; set; }
    }
}
