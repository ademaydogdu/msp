using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
  public partial  class CCustomers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CCID { get; set; }

        [StringLength(50)]
        public string CCAddress { get; set; }

        [StringLength(50)]
        public string CCAddressTwo { get; set; }

        [StringLength(50)]
        public string CCCity { get; set; }

        [StringLength(50)]
        public string CCDistrict { get; set; }

        public int CCCountryCode { get; set; }

        [StringLength(50)]
        public string CCCountry { get; set; }

        public int CCZipCode { get; set; }

        [StringLength(50)]
        public string CCEmail { get; set; }

        [StringLength(50)]
        public string CCPhone { get; set; }

        [StringLength(50)]
        public string CCPhoneTwo { get; set; }

        [StringLength(50)]
        public string CCFax { get; set; }

        [StringLength(50)]
        public string CCSpecCode { get; set; }

        public bool CCActive { get; set; }

        [StringLength(50)]
        public string CCTaxAdministration { get; set; }

        public long? CCTaxNo { get; set; }

        public long? CCTcNo { get; set; }

        [StringLength(50)]
        public string CCCardNo { get; set; }

        [StringLength(50)]
        public string CCSoleProp { get; set; }

        [StringLength(50)]
        public string CCSaleOnCredit { get; set; }

        [StringLength(50)]
        public string CCSpecSalePrice { get; set; }

    }
}
