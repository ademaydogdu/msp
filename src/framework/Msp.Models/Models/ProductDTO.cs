using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
  public class ProductDTO
    {
        public int id { get; set; }

        public string name { get; set; }

        public string barcode { get; set; }

        public int? categoryId { get; set; }

        public DateTime? date { get; set; }

        public long? firstPrice { get; set; }

        public long? total { get; set; }

        public long? lastPrice { get; set; }
    }
}
