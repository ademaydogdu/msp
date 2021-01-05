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

        public string PBarcode { get; set; } = "";

        public int? PCategoryId { get; set; }

        public DateTime? PDate { get; set; }

        public decimal? PFirstPrice { get; set; }

        public decimal? PTotal { get; set; }

        public decimal? PLastPrice { get; set; }

        public int PUnitId { get; set; }

        public int? PTax { get; set; }

        public string PVarDescription { get; set; }

        public string PSpecCode { get; set; }

        public string PBrandName { get; set; }

        public string PBrandCode { get; set; }

        public int? PGroup { get; set; }

        public byte[] PImages { get; set; }

        public DateTime? PExpDate { get; set; }

        public decimal? PSalePrice { get; set; } = 0;
        public int? PTaxType { get; set; } = 1;
        public decimal? PMalBedeli { get; set; } = 0;
        public decimal? PPaxAmout { get; set; } = 0;
        public bool? PKdvIstisna { get; set; } = false;
        public decimal? PKarPrice { get; set; } = 0;
        public string PCode { get; set; }
        public int? PCompanyId { get; set; }
        public int? PDepotId { get; set; }
        public bool? Deleted { get; set; } = false;



    }
}
