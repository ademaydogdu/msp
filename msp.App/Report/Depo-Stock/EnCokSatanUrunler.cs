using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models.Report;

namespace Msp.App.Report.Depo_Stock
{
    public partial class EnCokSatanUrunler : DevExpress.XtraReports.UI.XtraReport
    {
        public EnCokSatanUrunler()
        {
            InitializeComponent();
        }

        public void InitData(List<SumSaleStockDTO> saleStock)
        {
            objectDataSource1.DataSource = saleStock;
        }

    }
}
