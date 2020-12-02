using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class CurrencyTypeDTO
    {
        public int RecId { get; set; }
        public string CurrencyCode { get; set; }
        public string Remark { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
