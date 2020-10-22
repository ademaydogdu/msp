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
            frmOrdersReceived frm = new frmOrdersReceived();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrdersReceived frm = new frmOrdersReceived();
            frm.MdiParent = this;
            frm.Show();
        }
    }
    }
