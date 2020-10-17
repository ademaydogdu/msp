using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
  public  class BankEntry
    {
        [Key]

        public int bid { get; set; }

        [StringLength(50)]
        public string docNo { get; set; }

        [StringLength(50)]
        public string bankName { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public int? amountDeposited { get; set; }

        public int? withdrawnDeposited { get; set; }

        public DateTime? bDate { get; set; }

    }
}
