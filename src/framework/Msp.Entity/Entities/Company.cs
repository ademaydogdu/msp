using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int RecId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
    }
}
