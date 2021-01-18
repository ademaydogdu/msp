using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("ApplicationServer")]
    public class ApplicationServer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength]
        public string Server { get; set; }
        [MaxLength]
        public string ServerName { get; set; }
        [MaxLength(200)]
        public string UserName { get; set; }
        [MaxLength]
        public string Password { get; set; }
        public string DataBase { get; set; }


    }
}
