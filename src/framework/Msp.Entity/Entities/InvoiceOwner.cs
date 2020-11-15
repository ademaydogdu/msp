using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("InvoiceOwner")]
    public class InvoiceOwner
    {
        [Key]
        public int RecId { get; set; }
        public int? InvoiceType { get; set; }
        public DateTime? FicDate { get; set; }
        public TimeSpan? FichTime { get; set; }
        public int? FicheType { get; set; }
        public string FicheDocumentNo { get; set; }
        public string FicheRemark { get; set; }
        public int? CariRecId { get; set; }
        public DateTime? VadeTarih { get; set; }
        public int? DepoName { get; set; }
        public decimal? Indirim { get; set; }
        public decimal? AraToplam { get; set; }
        public decimal? ToplamKDV { get; set; }
        public decimal? DigerMasraflar { get; set; }
        public decimal? GenelToplam { get; set; }
    }
}
