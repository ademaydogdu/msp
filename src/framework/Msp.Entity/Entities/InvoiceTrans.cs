using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("InvoiceTrans")]
    public class InvoiceTrans
    {
        [Key]
        public int RecId { get; set; }
        public int? InvoiceOwnerId { get; set; }
        public int? ProductId { get; set; }
        public int? Quentity { get; set; }
        public int? UnitID { get; set; }
        public int? KDV { get; set; }
        public int? Indirim { get; set; }
        public decimal? BirimFiyat { get; set; }
        public decimal? Tutar { get; set; }
        public DateTime? SKT { get; set; }
        public decimal? AlisFiyati { get; set; }
        public int? KarOrani { get; set; }
        public decimal? KDVPrice { get; set; }

    }
}
