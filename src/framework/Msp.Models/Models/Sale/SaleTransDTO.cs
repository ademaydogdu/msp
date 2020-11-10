using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Sale
{
    public class SaleTransDTO
    {
        public int RecId { get; set; }
        public int? SaleOwnerId { get; set; }
        public int? ProductId { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? ProductAmount { get; set; }
        public int? CompanyId { get; set; }
        public bool? Deleted { get; set; }
        public int? UnitId { get; set; }
        public int? Tax { get; set; }
        public decimal? TaxAmount { get; set; }
        public DateTime ProductDate { get; set; }

    }
}
