using DevExpress.XtraReports.UI;
using Msp.Models.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Msp.App.Report.Barcode
{
    public partial class BarkodsuzUrun13 : DevExpress.XtraReports.UI.XtraReport
    {
        public BarkodsuzUrun13()
        {
            InitializeComponent();
        }

        public void InitData(List<ProductDTO> data)
        {
            objectDataSource1.DataSource = data;
        }


    }
}
