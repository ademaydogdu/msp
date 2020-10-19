using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("BankEntry")]
    public  class BankEntry
    {
        [Key]

        public int bid { get; set; }

        [StringLength(50)]
        public string docNo { get; set; }

   
        public int bankID { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public int? amountDeposited { get; set; }

        public int? withdrawnDeposited { get; set; }

        public DateTime? bDate { get; set; }

    }
}
