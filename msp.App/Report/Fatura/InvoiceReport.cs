using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models.Invoice;

namespace Msp.App.Report.Fatura
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        public void InitData(InvoiceOwnerDTO saleOwners)
        {
            objectDataSource1.DataSource = saleOwners;
        }

    }
}
