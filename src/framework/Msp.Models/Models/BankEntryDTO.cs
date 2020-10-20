using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class BankEntryDTO
    {

        public int bid { get; set; }

        public string docNo { get; set; }

        public int bankID { get; set; }

        public string description { get; set; }

        public int? amountDeposited { get; set; }

        public int? withdrawnDeposited { get; set; }

        public DateTime? bDate { get; set; }
    }
}
