using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class BanksDTO
    {

        public int Bid { get; set; }

        public string BankName { get; set; }

        public string BankBranch { get; set; }

        public int? BankBranchCode { get; set; }

        public string BankAccountNumber { get; set; }

        public string BankAccountName { get; set; }

        public int? CompanyRecId { get; set; }



    }
}
