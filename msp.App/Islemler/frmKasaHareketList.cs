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


        #region Record

        public void do_Refresh()
        {

        }


        #endregion


        private void frmKasaHareketList_Load(object sender, EventArgs e)
        {
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
            frm.Show();
        }

        private void btnCustomerRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Refresh();
        }
    }
}