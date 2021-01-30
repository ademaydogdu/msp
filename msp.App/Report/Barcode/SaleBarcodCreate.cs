using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models;

namespace Msp.App.Report.Barcode
{
    public partial class SaleBarcodCreate : DevExpress.XtraReports.UI.XtraReport
    {
        public SaleBarcodCreate()
        {
            InitializeComponent();
        }

        public void InitData(List<SaleBarcodCreateDTO> data)
        {
            objectDataSource1.DataSource = data;
        }

    }
}
