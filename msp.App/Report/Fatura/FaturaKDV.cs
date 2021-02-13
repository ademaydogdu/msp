using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Msp.Models.Models.Report;
using Msp.Service.Repository;
using Msp.Service.Service.Report;
using Msp.Infrastructure;
using Msp.Models.Models;

namespace Msp.App.Report.Fatura
{
    public partial class FaturaKDV : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public FaturaKDV()
        {
            InitializeComponent();
            _repository = new Repository();
        }


        List<KDVReportDto> kDVReports = new List<KDVReportDto>();


        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        #region Record

        public void do_refresh()
        {
            try
            {
                kDVReports = _repository.Run<ReportService, List<KDVReportDto>>(x => x.Get_List_KDVReport(AppMain.CompanyRecId,(DateTime)dt_Begindate.EditValue, (DateTime)dt_EndDate.EditValue));
                bs_KDVReport.DataSource = kDVReports;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        #endregion


        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FaturaKDV_Load(object sender, EventArgs e)
        {
            dt_Begindate.EditValue = DateTime.Today;
            dt_EndDate.EditValue = DateTime.Today;

            rp_KDV.DataSource = KdvOrani;
            rp_KDV.ValueMember = "Id";
            rp_KDV.DisplayMember = "Value";

        }

        private void btnReportGetir_Click(object sender, EventArgs e)
        {
            do_refresh();
        }
    }
}