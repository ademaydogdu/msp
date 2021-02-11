using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models.Invoice;
using System.Collections.Generic;
using Msp.Models.Models;
using Msp.Models.Models.Report.List;

namespace Msp.App.Report.Fatura
{
    public partial class InvoiceReport_Sablon1 : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport_Sablon1()
        {
            InitializeComponent();
        }
        public void InitData(InvoiceOwnerDTO saleOwners, List<ReportInvoiceTransDTO> List_InvoiceTrans, CTransactionsDTO cTransactions, ReportInvoice reports) 
        {
            objectDataSource1.DataSource = saleOwners;
            objectDataSource2.DataSource = List_InvoiceTrans;
            objectDataSource3.DataSource = cTransactions;
            objectDataSource4.DataSource = reports;

        }

    }
}
