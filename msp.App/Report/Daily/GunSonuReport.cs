using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models.Daily;

namespace Msp.App.Report.Daily
{
    public partial class GunSonuReport : DevExpress.XtraReports.UI.XtraReport
    {
        public GunSonuReport()
        {
            InitializeComponent();
        }

        public void InitData(DailyOwnerDTO saleOwners)
        {
            objectDataSource1.DataSource = saleOwners;
        }

    }
}
