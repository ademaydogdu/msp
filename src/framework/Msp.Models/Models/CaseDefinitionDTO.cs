using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class CaseDefinitionDTO
    {
        public int RecId { get; set; }
        public string CaseName { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
