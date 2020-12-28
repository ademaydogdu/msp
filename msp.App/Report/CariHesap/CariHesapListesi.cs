using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models;
using System.Collections.Generic;

namespace Msp.App.Report.CariHesap
{
    public partial class CariHesapListesi : DevExpress.XtraReports.UI.XtraReport
    {
        public CariHesapListesi()
        {
            InitializeComponent();
        }

        public void InitData(List<CTransactionsDTO> data)
        {
            objectDataSource1.DataSource = data;
        }


    }
}
