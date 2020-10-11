using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("SpeedSaleProduct")]
    public class SpeedSaleProduct
    {
        [Key]
        public int RecId { get; set; }
        public int? ProductId { get; set; }
        public string İmage { get; set; }
        public string ButtonType { get; set; }
    }
}
