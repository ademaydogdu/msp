using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("CurrentGroupDefinitions")]
    public class CurrentGroupDefinitions
    {
        [Key]
        public int RecId { get; set; }
        public string Remark { get; set; }
    }
}
