using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Msp.Models.Models.Invoice
{
    public class InvoiceSaveRequest
    {
        public InvoiceOwnerDTO InvoiceOwner { get; set; }
        public List<InvoiceTransDTO> InvoiceTrans { get; set; }
        public bool IsOrder { get; set; }

        public int _invoiceType { get; set; }
        public bool BirimFiyatChance { get; set; }
        public List<ProductDTO> _productList { get; set; }
    }
}
