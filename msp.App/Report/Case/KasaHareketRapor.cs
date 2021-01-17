using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Msp.Models.Models.Case;
using System.Collections.Generic;

namespace Msp.App.Report.Case
{
    public partial class KasaHareketRapor : DevExpress.XtraReports.UI.XtraReport
    {
        public KasaHareketRapor()
        {
            InitializeComponent();
        }

        public void InitData(List<CaseMovementDTO> caseMov)
        {
            objectDataSource1.DataSource = caseMov;
        }

    }
}
