using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.App
{
    public class ProgramsControlsDTO
    {
        public int RecId { get; set; }
        public string MspVersion { get; set; }
        public string Licence { get; set; }
        public DateTime? FirstDate { get; set; }
        public string MacAdress { get; set; }
        public string IpAdress { get; set; }
        public string LocalIpAdress { get; set; }
        public bool? IsDemo { get; set; }
    }
}
