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
using Msp.Service.Service.Sale;
using Msp.Models.Models.Sale;
using Msp.Models.Models.Utilities;
using Msp.App.Satis;

namespace Msp.App.Musteri_Islemleri
{
    public partial class frmMusterVeresiyeDetail : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmMusterVeresiyeDetail()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        MspTool mspTool = new MspTool();
        List<SaleOwnerDTO> __dll_SaleOwner = new List<SaleOwnerDTO>();

        public string musteriAdi;

        #region Record

        public void do_refresh()
        {
            __dll_SaleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_VeresiyeSale_Musteri(musteriAdi));
            bs_SaleOwner.DataSource = __dll_SaleOwner;
        }

        #endregion


        private void frmMusterVeresiyeDetail_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_Layout(this);
        }

        private void frmMusterVeresiyeDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_VeresiyeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                oRow.Veresiye = false;
                oRow.VeresiyeClosedDate = DateTime.Now;
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

        private void bbi_BakiyedenDus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                frmBakidenDus frm = new frmBakidenDus();
                frm._saleOwner = oRow;
                frm.ShowDialog(); 
            }
        }

        private void frmMusterVeresiyeDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                var saleTrans = _repository.Run<SaleService, List<SaleTransDTO>>(x => x.Get_List_SaleTrans_RecID(oRow.RecId));
                if (saleTrans.Count > 0)
                {
                    oRow._SaleTrans = saleTrans;
                }
                gridControl1.RefreshDataSource();
            }
        }

        private void bbiBakiyeAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                frmBakiyeAdd frm = new frmBakiyeAdd();
                frm.saleOwner = oRow;
                frm.ShowDialog();
            }
        }
    }
}