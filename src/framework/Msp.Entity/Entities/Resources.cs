using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("Resources")]
    public class Resources
    {
        public int UniqueID { get; set; }
        public int ResourceID { get; set; }
        public string ResourceName { get; set; }
        public int? Color { get; set; }
        public byte[] Image { get; set; }
        public string CustomField1 { get; set; }
    }
}
