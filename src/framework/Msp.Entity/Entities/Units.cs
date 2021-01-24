using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("Units")]
    public class Units
    {
        [Key]
        public int UID { get; set; }
        public string UName { get; set; }
        public int? CompanyRecId { get; set; }


    }
}
