using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("CaseMovement")]
    public class CaseMovement
    {
        [Key]
        public int RecId { get; set; }
        public int? CaseId { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? VadeDate { get; set; }
        public string VadeMonth { get; set; }
        public string EvrakNo { get; set; }
        public int? Doviz { get; set; }
        public int? IslemTuru { get; set; }
        public decimal? Tutar { get; set; }
        public int? OdemeTuru { get; set; }
        public int? OdemeGrubu { get; set; }
        public string Remark { get; set; }
        public int? CariId { get; set; }
        public bool? Deleted { get; set; }
        public int? CompanyRecId { get; set; }
        public string RecordUser { get; set; }
        public int? SaleOwnerId { get; set; }


    }
}
