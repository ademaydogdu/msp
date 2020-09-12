namespace Msp.Entity.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cashiers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string tcId { get; set; }

        public bool? authority { get; set; }

        public DateTime? date { get; set; }

        public long? salary { get; set; }

        public int? userId { get; set; }

        public int? cashNo { get; set; }

        public virtual Users users { get; set; }
    }
}
