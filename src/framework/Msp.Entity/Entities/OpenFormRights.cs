using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("OpenFormRights")]
    public class OpenFormRights
    {
        [Key]
        public int RecId { get; set; }
        public string UserCode { get; set; }
        public string ActionName { get; set; }
        public bool? OpenForm { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
