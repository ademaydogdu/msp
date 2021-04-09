using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models;

namespace Msp.App.Report.Barcode
{
    public partial class UrunBarcode8 : DevExpress.XtraReports.UI.XtraReport
    {
        public UrunBarcode8()
        {
            InitializeComponent();
        }

        public void InitData(ProductDTO data)
        {
            objectDataSource2.DataSource = data;
        }

    }
}
