using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("CaseDefinition")]
    public class CaseDefinition
    {
        [Key]
        public int RecId { get; set; }
        public string CaseName { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
