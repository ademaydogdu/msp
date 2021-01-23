using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Scheduler
{
    public class ResourcesDTO
    {
        public int UniqueID { get; set; }
        public int ResourceID { get; set; }
        public string ResourceName { get; set; }
        public int? Color { get; set; }
        public byte[] Image { get; set; }
        public string CustomField1 { get; set; }
    }
}
