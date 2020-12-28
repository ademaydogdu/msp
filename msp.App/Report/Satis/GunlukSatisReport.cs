using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models.Sale;

namespace Msp.App.Report.Satis
{
    public partial class GunlukSatisReport : DevExpress.XtraReports.UI.XtraReport
    {
        public GunlukSatisReport()
        {
            InitializeComponent();
        }

        public void InitData(List<SaleOwnerDTO> saleOwners)
        {
            objectDataSource1.DataSource = saleOwners;
        }

    }
}
