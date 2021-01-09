using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.App
{
    public class LogsDTO
    {
        public int RecId { get; set; }
        public string UserCode { get; set; }
        public string CompanyCode { get; set; }
        public string FieldName { get; set; }
        public string TableName { get; set; }
        public string Old { get; set; }
        public string New { get; set; }
        public string PCName { get; set; }
        public string FormName { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
