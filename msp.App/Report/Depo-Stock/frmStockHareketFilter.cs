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
using Msp.Infrastructure;
using Msp.Service.Repository;
using Msp.Service.Service.Report;
using Msp.Models.Models;

namespace Msp.App.Report.Depo_Stock
{
    public partial class frmStockHareketFilter : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmStockHareketFilter()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        private void do_report()
        {
            try
            {
                var filter = new CaseReportFilter
                {
                    companyId = AppMain.CompanyRecId,
                    BeginDate = dt_BaslangicDate.DateTime,
                    EndDate = dt_BitisDate.DateTime,
                };
                List<ProductMovementDTO> productMovements = _repository.Run<ReportService, List<ProductMovementDTO>>(x => x.Get_List_StokHareketListesi(filter));
                if (productMovements.Count > 0)
                {
                    //frmPrint frm = new frmPrint();
                    //frm.PrintKasaHareketRaporu(caseMovements);
                    //frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_report();
        }

        private void frmStockHareketFilter_Load(object sender, EventArgs e)
        {
            dt_BaslangicDate.EditValue = DateTime.Now;
            dt_BitisDate.EditValue = DateTime.Now;
            lc_ProductBegin.Properties.DataSource = AppMain._productsTask;
            lc_ProductEnd.Properties.DataSource = AppMain._productsTask;
        }
    }
}