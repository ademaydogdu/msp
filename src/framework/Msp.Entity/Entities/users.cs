namespace Msp.Entity.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            cashiers = new HashSet<Cashiers>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [Column(TypeName = "text")]
        public string note { get; set; }

        public DateTime? date { get; set; }

        public bool Active { get; set; }
        public string HaspPassword { get; set; }
        public string Email { get; set; }
        public string DefaultTheme { get; set; }
        public string DefaultTheme2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cashiers> cashiers { get; set; }
    }
}
