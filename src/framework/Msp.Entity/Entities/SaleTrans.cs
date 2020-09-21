using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("SaleTrans")]
    public class SaleTrans
    {
        [Key]
        public int RecId { get; set; }
        public int? SaleOwnerId { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductAmount { get; set; }
    }
}
