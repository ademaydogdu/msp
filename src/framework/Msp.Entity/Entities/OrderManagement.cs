using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("OrderManagement")]
    public class OrderManagement
    {

        [Key]
        public int oid { get; set; }

        public bool oType { get; set; }

        [StringLength(50)]
        public string oStatus { get; set; }

        public DateTime oDate { get; set; }

        public int oNo { get; set; }

        public int oAmount { get; set; }

        public int oCTransactionNo { get; set; }

        [StringLength(50)]
        public string oCTransactionTitle { get; set; }

        [StringLength(50)]
        public string oDescription { get; set; }
    }
}
