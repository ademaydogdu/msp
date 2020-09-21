﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class ParametersDTO
    {
        public int RecId { get; set; }
        public bool NumaratorShow { get; set; }
        public bool? SaleApproval { get; set; }
        public bool? SaleOutOfStock { get; set; }
        public bool? SaleCahnge { get; set; }
        public bool? SaleInformationSlip { get; set; }
        public bool? MainSaleForm { get; set; }
        public bool? AutoCurrency { get; set; }
        public bool? UserRecordMy { get; set; }
    }
}
