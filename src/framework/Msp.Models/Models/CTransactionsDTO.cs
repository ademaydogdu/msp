using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class CTransactionsDTO
    {
        public int CurId { get; set; }

        public string CurType { get; set; }

        public Int64 CurCode { get; set; }


        public string CurAccountName { get; set; }


        public string CurAuthPersonName { get; set; }

        public int CurDiscount { get; set; }

   
        public string CurRiskLimit { get; set; }

       
        public string CurCity { get; set; }

        public Int64 CurBalance { get; set; }

       
        public string CurCompanyType { get; set; }

        public DateTime? CurDate { get; set; }

        public DateTime? CurCreatedDate { get; set; }
    }
}
