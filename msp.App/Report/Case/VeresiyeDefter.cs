using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models.Sale;

namespace Msp.App.Report.Case
{
    public partial class VeresiyeDefter : DevExpress.XtraReports.UI.XtraReport
    {
        public VeresiyeDefter()
        {
            InitializeComponent();
        }

        public void InitData(List<SaleOwnerDTO> saleOwners)
        {
            objectDataSource1.DataSource = saleOwners;
        }


    }
}
