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
using Msp.Models.Models.Sale;
using Msp.App.Tool;
using Msp.Service.Repository;
using Msp.Service.Service.Sale;
using Msp.Models.Models.Utilities;
using Msp.Infrastructure;

namespace Msp.App.Satis
{
    public partial class frmVeresiyeSatisList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmVeresiyeSatisList()
        {
            _repository = new Repository();
            InitializeComponent();
        }
        MspTool mspTool = new MspTool();
        List<SaleOwnerDTO> __dll_SaleOwner = new List<SaleOwnerDTO>();

        private void do_refresh()
        {
            __dll_SaleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_VeresiyeSale());
            bs_SaleOwner.DataSource = __dll_SaleOwner;
        }

        private void frmVeresiyeSatisList_Load(object sender, EventArgs e)
        {
            if(AppMain.User.ExportExcelPdf.GetValueOrDefault() == false) { bbi_exp.Enabled = false; }else { bbi_exp.Enabled = true; }
            do_refresh();

            mspTool.Get_GridControl(this.Name, gc_SiparisList);

        }

        private void frmVeresiyeSatisList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gc_SiparisList);

        }

        private void frmVeresiyeSatisList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            mspTool.Export2AnyDocument("xls", gc_SiparisList);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("pdf", gc_SiparisList);
        }

        private void bbi_VeresiyeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (AppMain.User.VeresiyeDefterClosed.GetValueOrDefault() == false)
            {
                XtraMessageBox.Show("Veresiye Kapatma Yetkiniz Yoktur.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                oRow.Veresiye = false;
                oRow.VeresiyeClosedDate = DateTime.Now;
                oRow.Remark = oRow.Remark + " - " + Convert.ToString(oRow.Date) + "Satışı yapılan kaydın tahsilatı yapılmıştır.";
                oRow.Date = DateTime.Now;
                var response = _repository.Run<SaleService, ActionResponse<SaleOwnerDTO>>(x => x.Update_Veresiye(oRow));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    do_refresh();
                }
            }
        }

        private void bbi_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SaleOwnerDTO oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                var saleTrans = _repository.Run<SaleService, List<SaleTransDTO>>(x => x.Get_List_SaleTrans_RecID(oRow.RecId));
                if (saleTrans.Count > 0)
                {
                    oRow._SaleTrans = saleTrans;
                }
                gc_SiparisList.RefreshDataSource();
            }
        }
    }
}