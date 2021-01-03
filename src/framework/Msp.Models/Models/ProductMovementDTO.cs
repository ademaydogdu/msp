using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class ProductMovementDTO
    {
        public int RecId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Durum { get; set; }
        public bool? Deleted { get; set; } = false;
    }
}
