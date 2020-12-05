using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Order
{
    public class OrderRequest
    {
        public OrderOwnerDTO OrderOwner { get; set; }
        public List<OrderTransDTO> OrderTrans { get; set; }
    }
}
