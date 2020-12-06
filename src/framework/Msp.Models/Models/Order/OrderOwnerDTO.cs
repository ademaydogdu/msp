using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Order
{
    public class OrderOwnerDTO
    {
        public int RecId { get; set; }
        public int? CariRecId { get; set; }
        public int? OrderType { get; set; }
        public int? CompanyId { get; set; }
        public string SiparisNo { get; set; }
        public DateTime? SiparisDate { get; set; }
        public TimeSpan? SiparisTime { get; set; }
        public string OzelKod { get; set; }
        public int? DovizId { get; set; }
        public string Kdv { get; set; }
        public int? Iskonto { get; set; }
        public string Durum { get; set; }
        public int? TeklifSiparis { get; set; }
        public string Remark { get; set; }
        public decimal? TotalToplam { get; set; } = 0;
        public decimal? TotalIskonto { get; set; } = 0;
        public decimal? TotalKDV { get; set; } = 0;
        public decimal? TotalSiparis { get; set; } = 0;
        public decimal? TotalAraToplam { get; set; } = 0;
        public bool? Deleted { get; set; }
        public int? IrsaliyeId { get; set; } = 0;

    }
}
