using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class ExchangeRateDTO
    {
        public int RecId { get; set; }
        public DateTime CurrDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? Invoice { get; set; }
        public decimal? Exchange { get; set; }
        public decimal? Pos { get; set; }
        public decimal? Buying { get; set; }
        public decimal? Selling { get; set; }
        public decimal? EffectiveBuying { get; set; }
        public decimal? EffectiveSelling { get; set; }
        public string RecordUser { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
