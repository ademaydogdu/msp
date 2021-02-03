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
using Msp.Service.Repository;
using Msp.App.Tool;
using Msp.Models.Models;
using Msp.Service.Service.Tanimlar;
using Msp.Infrastructure;
using Msp.Models.Models.Report;
using Msp.Models.Models.Case;
using Msp.Service.Service.Report;

namespace Msp.App.Report.Case
{
    public partial class frmKasaReportFilter : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmKasaReportFilter()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool mspTool = new MspTool();
        public int FormType;
        //1 = KasaBakiyeRaporu, 2 = KasaHareketRaporu
        List<CaseDefinitionDTO> __List_CaseDef = new List<CaseDefinitionDTO>();



        private void frmKasaReportFilter_Load(object sender, EventArgs e)
        {
            mspTool.Get_Layout(this);

            switch (FormType)
            {
                case 1:
                    layoutControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case 2:
                    layoutControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                default:
                    break;
            }
            __List_CaseDef = _repository.Run<DefinitionsService, List<CaseDefinitionDTO>>(x => x.Get_List_CaseDef(AppMain.CompanyRecId));
            bs_CaseList.DataSource = __List_CaseDef;

            dt_BaslangicDate.EditValue = DateTime.Today;
            dt_BitisDate.EditValue = DateTime.Today;

        }

        private void frmKasaReportFilter_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKasaReportFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void do_report()
        {
            try
            {
                var filter = new CaseReportFilter
                {
                    companyId = AppMain.CompanyRecId,
                    BeginDate = dt_BaslangicDate.DateTime,
                    EndDate = dt_BitisDate.DateTime,
                    CaseId = Convert.ToInt32(lc_Case.EditValue)
                };

                if (FormType == 1)
                {
                    List<CaseBakiyeReportDTO> caseBakiye = _repository.Run<ReportService, List<CaseBakiyeReportDTO>>(x => x.Get_List_CaseBakiyeReport(filter));
                    bs_CaseBakiye.DataSource = caseBakiye;
                    gc_KasaBakiye.RefreshDataSource();
                    if (caseBakiye.Count > 0)
                    {
                        frmPrint frm = new frmPrint();
                        frm.PrintCaseBakiye(caseBakiye);
                        frm.ShowDialog();
                    }
                }
                if (FormType == 2)
                {
                    List<CaseMovementDTO> caseMovements = _repository.Run<ReportService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement(filter));
                    bs_CaseList.DataSource = caseMovements;
                    gc_KasaHareket.RefreshDataSource();
                    if (caseMovements.Count > 0)
                    {
                        frmPrint frm = new frmPrint();
                        frm.PrintKasaHareketRaporu(caseMovements);
                        frm.ShowDialog(); 
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public void do_report_Grid()
        {
            try
            {
                var filter = new CaseReportFilter
                {
                    companyId = AppMain.CompanyRecId,
                    BeginDate = dt_BaslangicDate.DateTime,
                    EndDate = dt_BitisDate.DateTime,
                    CaseId = Convert.ToInt32(lc_Case.EditValue)
                };

                if (FormType == 1)
                {
                    List<CaseBakiyeReportDTO> caseBakiye = _repository.Run<ReportService, List<CaseBakiyeReportDTO>>(x => x.Get_List_CaseBakiyeReport(filter));
                    bs_CaseBakiye.DataSource = caseBakiye;
                    gc_KasaBakiye.RefreshDataSource();
                }
                if (FormType == 2)
                {
                    List<CaseMovementDTO> caseMovements = _repository.Run<ReportService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement(filter));
                    bs_CaseList.DataSource = caseMovements;
                    gc_KasaHareket.RefreshDataSource();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        private void btnRaporla_Click(object sender, EventArgs e)
        {
            do_report();
        }

        private void btnRaposuzGoster_Click(object sender, EventArgs e)
        {
            do_report_Grid();
        }
    }
}