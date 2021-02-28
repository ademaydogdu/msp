using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("Parameters")]
    public class Parameters
    {
        [Key]
        public int RecId { get; set; }
        public bool? NumaratorShow { get; set; } = false;
        public bool? SaleApproval { get; set; } = false;
        public bool? SaleOutOfStock { get; set; } = false;
        public bool? SaleCahnge { get; set; } = false;
        public bool? SaleInformationSlip { get; set; } = false;
        public bool? MainSaleForm { get; set; } = false;
        public bool? AutoCurrency { get; set; } = false;
        public bool? UserRecordMy { get; set; } = false;
        public bool? PaymentLock { get; set; } = false;
        public bool? PaymentyForced { get; set; } = false;
        public bool? SaleNewRecord { get; set; } = false;
        public bool? SaleProductEndDate { get; set; } = false;
        public bool? PaymentFisSave { get; set; } = false;
        public int? ProductEndDateDay { get; set; } = 0;
        public bool? IsBarcode { get; set; } = false;
        public string BorcodeCOM { get; set; }
        public int? ReportType { get; set; } = 0;


    }
}
