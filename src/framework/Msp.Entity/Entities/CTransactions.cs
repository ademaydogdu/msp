using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
   public partial class CTransactions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurId { get; set; }

        [StringLength(50)]
        public string CurType{ get; set; }

        public Int64 CurCode { get; set; }

        [StringLength(50)]
        public string CurAccountName { get; set; }

        [StringLength(50)]
        public string CurAuthPersonName { get; set; }

        public int CurDiscount { get; set; }

        [StringLength(50)]
        public string CurRiskLimit { get; set; }

        [StringLength(50)]
        public string CurCity { get; set; }

        public Int64 CurBalance { get; set; }

        [StringLength(50)]
        public string CurCompanyType { get; set; }

        public DateTime? CurDate { get; set; }

        public DateTime? CurCreatedDate { get; set; }
    }
}
