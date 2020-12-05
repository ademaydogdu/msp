using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("OrderTrans")]
    public class OrderTrans
    {
        [Key]
        public int? RecId { get; set; }
        public int? OwnerId { get; set; }
        public int? StockId { get; set; }
        public int? Miktar { get; set; }
        public string Sevk { get; set; }
        public string Bekleyen { get; set; }
        public int? BirimId { get; set; }
        public decimal? BirimFiyat { get; set; }
        public int? KDV { get; set; }
        public decimal? Tutar { get; set; }
        public string Remark { get; set; }
    }
}
