using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models;
using System.Collections.Generic;

namespace Msp.App.Report.Barcode
{
    public partial class BarocedList : DevExpress.XtraReports.UI.XtraReport
    {
        public BarocedList()
        {
            InitializeComponent();
        }

        public void InitData(List<ProductDTO> data)
        {
            objectDataSource1.DataSource = data;
        }

    }
}
