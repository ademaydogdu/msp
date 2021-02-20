using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("SimleCurrentDefinition")]
    public class SimleCurrentDefinition
    {
        [Key]
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
