using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Order
{
    public class OrderTransDTO
    {
        public int? RecId { get; set; } = 0;
        public int? OwnerId { get; set; }
        public int? StockId { get; set; }
        public int? Miktar { get; set; } = 0;
        public string Sevk { get; set; }
        public string Bekleyen { get; set; }
        public int? BirimId { get; set; }
        public decimal? BirimFiyat { get; set; } = 0;
        public int? KDV { get; set; }
        public decimal? Tutar { get; set; } = 0;
        public string Remark { get; set; }
    }
}
