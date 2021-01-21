using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class ProductBarCodeDTO
    {
        public int RecId { get; set; }
        public int? ProductId { get; set; }
        public string Barcode { get; set; }
        public string Remark { get; set; }
        public int? CompanyRecId { get; set; }
    }
}
