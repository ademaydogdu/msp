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
using Msp.Models.Models.Case;
using Msp.Service.Service.Case;
using Msp.Infrastructure;

namespace Msp.App.Islemler
{
    public partial class frmKasaHareketList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmKasaHareketList()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool mspTool = new MspTool();
        List<CaseMovementDTO> _List_CaseMov = new List<CaseMovementDTO>();

        #region Record

        public void do_refresh()
        {
            _List_CaseMov = _repository.Run<CaseService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement(AppMain.CompanyRecId));
            bs_CaseMov.DataSource = _List_CaseMov;
        }


        #endregion


        private void frmKasaHareketList_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_Layout(this);
        }

        private void frmKasaHareketList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void btnCustomerClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasaHareketi frm = new frmKasaHareketi();
            frm._FormOpenType = Infrastructure.FormOpenType.New;
            frm.Show(0);
        }

        private void btnCustomerRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void btnEditCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (CaseMovementDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                frmKasaHareketi frm = new frmKasaHareketi();
                frm._FormOpenType = FormOpenType.Edit;
                frm.Show(oRow.RecId);
            }
  
        }
    }
}