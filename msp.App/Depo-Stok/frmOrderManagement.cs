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

namespace Msp.App.Depo_Stok
{
    public partial class frmOrderManagement : DevExpress.XtraEditors.XtraForm
    {
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNewOrder frm = new frmNewOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNewOrder frm = new frmNewOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReceivedOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNewOrder frm = new frmNewOrder();
            frm.Show();

        }

        private void btnPlacedOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrderPlaced frm = new frmOrderPlaced();
            frm.Show();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
