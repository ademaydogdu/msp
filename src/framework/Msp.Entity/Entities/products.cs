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
        public string PBarcode { get; set; }

        public int? PCategoryId { get; set; }

        public DateTime? PDate { get; set; }

        public long? PFirstPrice { get; set; }

        public long? PTotal { get; set; }

        public long? PLastPrice { get; set; }

        public int? PUnitId { get; set; }



        [StringLength(50)]
        public string PTax { get; set; }

        public string PVarDescription { get; set; }

        public string PSpecCode { get; set; }

        public string PBrandName { get; set; }

        public string PBrandCode { get; set; }

        public string PGroup { get; set; }

        //public virtual Categories categories { get; set; }
    }
}
