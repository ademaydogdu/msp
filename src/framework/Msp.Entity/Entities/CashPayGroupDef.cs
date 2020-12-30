using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
   public class CashPayGroupDef
    {

        [Key]
        public int RecId { get; set; }
        public string CashPayGroup { get; set; }
        public string ReCashPayGroup { get; set; }
    }
}
