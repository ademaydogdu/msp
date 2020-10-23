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
        public int CurID { get; set; }

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

        public DateTime? CurCreatedDate { get; set; }

        [StringLength(50)]
        public string CurAdress { get; set; }

        [StringLength(50)]
        public string CurAdressTwo { get; set; }

        public int CurCountryCode { get; set; }

        [StringLength(50)]
        public string CurCountryName { get; set; }

        public int CurZipCode { get; set; }

        [StringLength(50)]
        public string CurPhoneOne { get; set; }

        [StringLength(50)]
        public string CurPhoneOneTwo { get; set; }

        [StringLength(50)]
        public string CurFax { get; set; }

        [StringLength(50)]
        public string CurEmail { get; set; }

        [StringLength(50)]
        public string CurDescription { get; set; }

        [StringLength(50)]
        public string CurTaxNo { get; set; }

        [StringLength(50)]
        public string TaxOffice { get; set; }

        [StringLength(50)]
        public string CurCardNo { get; set; }

        [StringLength(50)]
        public string CurIdentNo { get; set; }
      
        [StringLength(50)]
        public string CurTitle { get; set; }
    }
}
