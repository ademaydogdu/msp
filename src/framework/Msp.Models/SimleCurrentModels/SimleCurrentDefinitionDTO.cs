using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.SimleCurrentModels
{
    public class SimleCurrentDefinitionDTO
    {
        public int RecId { get; set; }
        public string CUnvan { get; set; }
        public string Adress { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string SicilNo { get; set; }
        public string Mersis { get; set; }
        public int? Phone { get; set; }
        public int? Fax { get; set; }
        public string EPosta { get; set; }
    }
}
