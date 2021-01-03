using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models;
using System.Collections.Generic;

namespace Msp.App.Report.Depo_Stock
{
    public partial class EnvanterBilgileri : DevExpress.XtraReports.UI.XtraReport
    {
        public EnvanterBilgileri()
        {
            InitializeComponent();
        }

        public void InitData(List<ProductDTO> products)
        {
            objectDataSource1.DataSource = products;
        }

    }
}
