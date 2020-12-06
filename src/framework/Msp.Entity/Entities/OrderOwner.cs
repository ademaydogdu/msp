using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("OrderOwner")]
    public class OrderOwner
    {
        [Key]
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
        public decimal? TotalToplam { get; set; }
        public decimal? TotalIskonto { get; set; }
        public decimal? TotalKDV { get; set; }
        public decimal? TotalSiparis { get; set; }
        public bool? Deleted { get; set; }
        public int? IrsaliyeId { get; set; }
    }
}
