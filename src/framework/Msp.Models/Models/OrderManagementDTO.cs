using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
   public class OrderManagementDTO
    {

        public int oid { get; set; }


        public Boolean oType { get; set; }

 
        public string oStatus { get; set; }

        public DateTime oDate { get; set; }

        public int oNo { get; set; }

        public int oAmount { get; set; }

        public int oCTransactionNo { get; set; }


        public string oCTransactionTitle { get; set; }


        public string oDescription { get; set; }

    }
}
