using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Msp.Models.Models
{
    public class TCMBCurrency
    {
        [XmlAttribute("CrossOrder")]
        public string CrossOrder { get; set; }
        [XmlAttribute("Kod")]
        public string Code { get; set; }
        [XmlAttribute("CurrencyCode")]
        public string CurrencyCode { get; set; }
        public string Unit { get; set; }
        [XmlElement("Isim")]
        public string Name { get; set; }
        public string CurrencyName { get; set; }
        public string ForexBuying { get; set; }
        public string ForexSelling { get; set; }
        public string BanknoteBuying { get; set; }
        public string BanknoteSelling { get; set; }
        public string CrossRateUSD { get; set; }
        public string CrossRateOther { get; set; }
    }
}
