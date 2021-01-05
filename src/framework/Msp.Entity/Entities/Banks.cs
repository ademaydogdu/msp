using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
   public class Banks
    {
        [Key]
        public int Bid { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string BankBranch { get; set; }

        public int? BankBranchCode { get; set; }

        [StringLength(50)]
        public string BankAccountNumber { get; set; }

        [StringLength(50)]
        public string BankAccountName { get; set; }

    }
}
