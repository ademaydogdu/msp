using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Invoice
{
    public class InvoiceTransDTO
    {
        public int RecId { get; set; }
        public int? InvoiceOwnerId { get; set; }
        public int? ProductId { get; set; }
        public int? Quentity { get; set; } = 0;
        public int? UnitID { get; set; }
        public int? KDV { get; set; }
        public int? Indirim { get; set; }
        public decimal? BirimFiyat { get; set; } = 0;
        public decimal? Tutar { get; set; } = 0;
        public DateTime? SKT { get; set; }
        public decimal? AlisFiyati { get; set; } = 0;
        public int? KarOrani { get; set; }
        public decimal? KDVPrice { get; set; }
    }
}
