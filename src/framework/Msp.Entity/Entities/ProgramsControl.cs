using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("ProgramsControl")]
    public class ProgramsControl
    {
        [Key]
        public int RecId { get; set; }
        public string MspVersion { get; set; }
        public string Licence { get; set; }
        public DateTime? FirstDate { get; set; }
        public string MacAdress { get; set; }
        public string IpAdress { get; set; }
        public string LocalIpAdress { get; set; }
        public int? IsDemo { get; set; }

    }
}
