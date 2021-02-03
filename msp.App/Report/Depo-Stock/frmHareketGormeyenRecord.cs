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
using Msp.Models.Models;
using Msp.App.Tool;

namespace Msp.App.Report.Depo_Stock
{
    public partial class frmHareketGormeyenRecord : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmHareketGormeyenRecord()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        MspTool mspTool = new MspTool();
        List<ProductDTO> _productlist = new List<ProductDTO>();

        #region Record

        private void do_report()
        {
            try
            {
                if (_productlist.Count == 0) return;


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void do_refresh()
        {
            try
            {
                _productlist = _repository.Run<ReportService, List<ProductDTO>>(x => x.Get_List_HareketGormeyenStock((DateTime)dt_BaslangicDate.EditValue, (DateTime)dt_EndDate.EditValue));
                bs_products.DataSource = _productlist;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void frmHareketGormeyenRecord_Load(object sender, EventArgs e)
        {
            dt_BaslangicDate.EditValue = DateTime.Today;
            dt_EndDate.EditValue = DateTime.Today;
            mspTool.Get_Layout(this);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmHareketGormeyenRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void frmHareketGormeyenRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_report();
        }
    }
}