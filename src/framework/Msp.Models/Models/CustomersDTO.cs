using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
   public class CustomersDTO
    {
        public int id { get; set; }

       
        public string name { get; set; }

        
        public string surname { get; set; }

        
        public string address { get; set; }

        public string phone { get; set; }

        public bool? active { get; set; }

        public DateTime? date { get; set; }
    }
}
