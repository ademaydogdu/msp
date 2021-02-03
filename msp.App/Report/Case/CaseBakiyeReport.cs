using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Msp.Models.Models.Report;

namespace Msp.App.Report.Case
{
    public partial class CaseBakiyeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CaseBakiyeReport()
        {
            InitializeComponent();
        }

        public void InitData(List<CaseBakiyeReportDTO> caseMov)
        {
            objectDataSource1.DataSource = caseMov;
        }

    }
}
