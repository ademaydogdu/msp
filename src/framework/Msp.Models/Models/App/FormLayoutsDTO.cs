using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.App
{
    public class FormLayoutsDTO
    {
        public int RecId { get; set; }
        public string UserCode { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public byte[] XmlData { get; set; }
        public int ApplicationId { get; set; }
    }
}
