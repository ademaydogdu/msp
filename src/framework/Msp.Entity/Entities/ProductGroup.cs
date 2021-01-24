using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("ProductGroup")]
    public class ProductGroup
    {
        [Key]
        public int RecId { get; set; }
        public string Grouup { get; set; }
        public string ReGroup { get; set; }
        public int? CompanyRecId { get; set; }

    }
}
