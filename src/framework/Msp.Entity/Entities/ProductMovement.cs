using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("ProductMovement")]
    public class ProductMovement
    {
        [Key]
        public int RecId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public bool? Deleted { get; set; } = false;
        public string Durum { get; set; }
    }
}
