using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
     [Table("Depot")]
   public class Depots
    {

        [Key]
        public int DID { get; set; }

        [StringLength(50)]
        public string DepAuthPerson { get; set; }

        [StringLength(50)]
        public string DepPhoneOne { get; set; }

        [StringLength(50)]
        public string DepPhoneTwo { get; set; }

        [StringLength(50)]
        public string DepTaxAdministration { get; set; }

        [StringLength(50)]
        public string DepTaxNo { get; set; }

        public DateTime? DepDate { get; set; }

        public bool? active { get; set; }

    }
}
