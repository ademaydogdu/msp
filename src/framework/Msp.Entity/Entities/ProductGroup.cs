using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
   public class ProductGroup
    {
        [Key]
        public int RecId { get; set; }
        public string Grouup  { get; set; }
        public string ReGroup { get; set; }
    }
}
