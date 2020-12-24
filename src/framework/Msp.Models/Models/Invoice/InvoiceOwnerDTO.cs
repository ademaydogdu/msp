using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Invoice
{
    public class InvoiceOwnerDTO
    {
        public int RecId { get; set; }
        public int? InvoiceType { get; set; }
        public DateTime? FicDate { get; set; }
        public int? FicheType { get; set; }
        public string FicheDocumentNo { get; set; }
        public string FicheRemark { get; set; }
        public int? CariRecId { get; set; }
        public DateTime? VadeTarih { get; set; }
        public int? DepoName { get; set; }
        public decimal? Indirim { get; set; } = 0;
        public decimal? AraToplam { get; set; } = 0;
        public decimal? ToplamKDV { get; set; } = 0;
        public decimal? DigerMasraflar { get; set; } = 0;
        public decimal? GenelToplam { get; set; } = 0;
        public int? CompanyId { get; set; }
        public string EFaturaNo { get; set; }
        public string EIrsaliyeNo { get; set; }
        public bool? InoviceCancel { get; set; }
        public bool? InvoicePrint { get; set; }
        public int? VadeGun { get; set; }
        public DateTime? VadeDate { get; set; }
        public DateTime? IrsaliyeDate { get; set; }
        public string IrsaliyeNo { get; set; }
        public int? DovizTuru { get; set; }
        public string KDV { get; set; }
        public int? Iskonto { get; set; }
        public string PaymentType { get; set; }
        public bool? Deleted { get; set; } = false;
        public int? OrderId { get; set; } = 0;

    }
}
