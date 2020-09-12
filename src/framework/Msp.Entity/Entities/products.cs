namespace Msp.Entity.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string barcode { get; set; }

        public int? categoryId { get; set; }

        public DateTime? date { get; set; }

        public long? firstPrice { get; set; }

        public long? total { get; set; }

        public long? lastPrice { get; set; }

        public virtual Categories categories { get; set; }
    }
}
