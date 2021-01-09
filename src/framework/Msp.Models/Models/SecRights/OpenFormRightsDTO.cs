using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.SecRights
{
    public class OpenFormRightsDTO
    {
        public int RecId { get; set; }
        public string UserCode { get; set; }
        public string ActionName { get; set; }
        public bool? OpenForm { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
