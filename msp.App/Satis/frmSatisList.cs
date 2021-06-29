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
using Msp.Models.Models.Sale;
using Msp.Service.Service.Sale;
using Msp.App.Tool;
using msp.App;
using Msp.App.Report;
using Msp.Models.Models.Utilities;
using Msp.Infrastructure;

namespace Msp.App.Satis
{
    public partial class frmSatisList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmSatisList()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        MspTool mspTool = new MspTool();
        List<SaleOwnerDTO> __dll_SaleOwner = new List<SaleOwnerDTO>();


        #region Record
        private void do_refresh(DateTime date)
        {

            try
            {
                __dll_SaleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_Date(date));
                bs_SaleOwner.DataSource = __dll_SaleOwner;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        #endregion


        private void frmSatisList_Load(object sender, EventArgs e)
        {
            dt_Date.EditValue = DateTime.Today;
            do_refresh(dt_Date.DateTime);

            mspTool.Get_GridControl(this.Name, gc_SiparisList);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            do_refresh(dt_Date.DateTime);
        }

        private void frmSatisList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gc_SiparisList);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("xls", gc_SiparisList);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("pdf", gc_SiparisList);

        }

        private void bbi_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (__dll_SaleOwner.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.DailySaleOwner(__dll_SaleOwner);
                frm.ShowDialog();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            SaleOwnerDTO oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                frmSatis frm = new frmSatis();
                frm.MdiParent = this.MdiParent;
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(oRow.RecId);

            }
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Delete, (int)DocumentType.Satis, AppMain.CompanyRecId)) return;

            SaleOwnerDTO oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                if (mspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<SaleService, ActionResponse<SaleOwnerDTO>>(x => x.Delete_Sale(oRow));
                    if (result.ResponseType != ResponseType.Ok)
                    {
                        XtraMessageBox.Show(result.Message);
                    }
                    else
                    {
                        do_refresh(dt_Date.DateTime);
                    }
                }
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DateTime date = Convert.ToDateTime(gridView1.GetRowCellValue(e.RowHandle, colVeresiyeClosedDate));
            if (date != new DateTime(0001,01,01))
            {
                e.Appearance.BackColor = Color.LightBlue;
            }
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