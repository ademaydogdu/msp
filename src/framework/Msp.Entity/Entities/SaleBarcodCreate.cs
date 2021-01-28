using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("SaleBarcodCreate")]
    public class SaleBarcodCreate
    {
        [Key]
        public int RecId { get; set; }
        public int Type { get; set; }
        public string Barcode { get; set; }
    }
}
