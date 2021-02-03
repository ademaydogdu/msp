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
using Msp.Service.Service.Report;
using Msp.Models.Models.Report;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.Depot;
using Msp.App.Tool;

namespace Msp.App.Report.Depo_Stock
{
    public partial class frmStockBakiye : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmStockBakiye()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        MspTool MspTool = new MspTool();
        List<StockBakiyeReportDTO> __List_StockBakiye = new List<StockBakiyeReportDTO>();
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<DepotDTO> _depotList = new List<DepotDTO>();


        #region Record

        public void do_refresh()
        {
            try
            {
                __List_StockBakiye = _repository.Run<ReportService, List<StockBakiyeReportDTO>>(x => x.Get_List_StockBakiyeReport(AppMain.CompanyRecId));
                bs_StockBakiye.DataSource = __List_StockBakiye;
            }
            catch (Exception ex)
            {

            }
        }

        public void do_report()
        {

        }


        #endregion


        private void frmStockBakiye_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);
            dt_BeginDate.EditValue = DateTime.Today;
            dt_EndDate.EditValue = DateTime.Today;

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = _list_UnitsDTO;

            _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            bs_Depot.DataSource = _depotList;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_report();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void frmStockBakiye_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void frmStockBakiye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}