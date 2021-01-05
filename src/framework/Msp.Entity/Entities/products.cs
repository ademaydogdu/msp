namespace Msp.Entity.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [Key]
        public int PID { get; set; }

        [StringLength(50)]
        public string PName { get; set; }

        [StringLength(50)]
        public string PBarcode { get; set; } = "";

        public int? PCategoryId { get; set; }

        public DateTime? PDate { get; set; }

        public decimal? PFirstPrice { get; set; }

        public decimal? PTotal { get; set; }

        public decimal? PLastPrice { get; set; }

        public int? PUnitId { get; set; }

        public int? PTax { get; set; }

        public string PVarDescription { get; set; }

        public string PSpecCode { get; set; }

        public string PBrandName { get; set; }

        public string PBrandCode { get; set; }

        public int? PGroup { get; set; }

        public byte[] PImages { get; set; }

        public DateTime? PExpDate { get; set; }

        public decimal? PSalePrice { get; set; }
        public int? PTaxType { get; set; } = 0;
        public decimal? PMalBedeli { get; set; }
        public decimal? PPaxAmout { get; set; }
        public bool? PKdvIstisna { get; set; } = false;
        public decimal? PKarPrice { get; set; } = 0;
        public string PCode { get; set; }
        public int? PCompanyId { get; set; }
        public int? PDepotId { get; set; }
        public bool? Deleted { get; set; } = false;


        //public virtual Categories categories { get; set; }
    }
}
