using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
  public class ProductDTO
    {
        public int PID { get; set; }

        public string PName { get; set; }

        public string PBarcode { get; set; }

        public int? PCategoryId { get; set; }

        public DateTime? PDate { get; set; }

        public decimal? PFirstPrice { get; set; }

        public decimal? PTotal { get; set; }

        public decimal? PLastPrice { get; set; }

        public int PUnitId { get; set; }

        public string PTax { get; set; }

        public string PVarDescription { get; set; }

        public string PSpecCode { get; set; }

        public string PBrandName { get; set; }

        public string PBrandCode { get; set; }

        public string PGroup { get; set; }
    }
}
