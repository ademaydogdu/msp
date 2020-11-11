using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models;

namespace Msp.App.Report
{
    public partial class ProductList : DevExpress.XtraReports.UI.XtraReport
    {
        public ProductList()
        {
            InitializeComponent();
        }

        public void InitData(List<ProductDTO> products)
        {
            objectDataSource1.DataSource = products;
        }

    }
}
