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
    }
}
