using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
  public  class CCustomersDTO
    {
        public int CCID { get; set; }

        public string CCAddress { get; set; }

        public string CCAddressTwo { get; set; }

        public string CCCity { get; set; }

        public string CCDistrict { get; set; }

        public int CCCountryCode { get; set; }

        public string CCCountry { get; set; }

        public int CCZipCode { get; set; }

        public string CCEmail { get; set; }

        public string CCPhone { get; set; }

        public string CCPhoneTwo { get; set; }

        public string CCFax { get; set; }

        public string CCSpecCode { get; set; }

        public bool CCActive { get; set; }

        public string CCTaxAdministration { get; set; }

        public long? CCTaxNo { get; set; }

        public long? CCTcNo { get; set; }

        public string CCCardNo { get; set; }

        public string CCSoleProp { get; set; }

        public string CCSaleOnCredit { get; set; }

        public string CCSpecSalePrice { get; set; }
    }
}
