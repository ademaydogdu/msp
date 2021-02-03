using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class CTransactionsDTO
    {
        
        public int CurID { get; set; }

        public string CurType { get; set; }

        public string CurCode { get; set; }

        public string CurAccountName { get; set; }

        public string CurAuthPersonName { get; set; }

        public int? CurDiscount { get; set; }

        public string CurRiskLimit { get; set; }

        public string CurCity { get; set; }

        public string CurDistrict { get; set; }

        public Int64? CurBalance { get; set; }
       
        public string CurCompanyType { get; set; }

        public DateTime? CurCreatedDate { get; set; }

        public string CurAdress { get; set; }

        public string CurAdressTwo { get; set; }

        public int? CurCountryCode { get; set; }

        public string CurCountryName { get; set; }

        public int? CurZipCode { get; set; }

        public string CurPhoneOne { get; set; }

        public string CurPhoneTwo { get; set; }

        public string CurFax { get; set; }

        public string CurEmail { get; set; }

        public string CurDescription { get; set; }

        public string CurTaxNo { get; set; }

        public string CurTaxOffice { get; set; }

        public string CurCardNo { get; set; }

        public string CurIdentNo { get; set; }
        public string CurTitle { get; set; }
        public int? CompanyRecId { get; set; }
        public int? GroupId { get; set; }

    }
}
