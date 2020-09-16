using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int RecId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public byte[] Logo { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string BulvarCadde { get; set; }
        public int? TelNo { get; set; }
        public string BinaAdi { get; set; }
        public string BinaNo { get; set; }
        public string MahalleSemt { get; set; }
        public string Sehir { get; set; }
        public int? PostaKodu { get; set; }
        public string Ulke { get; set; }
    }
}
