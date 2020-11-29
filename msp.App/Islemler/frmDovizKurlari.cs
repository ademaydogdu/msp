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

namespace Msp.App.Islemler
{
    public partial class frmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frmDovizKurlari()
        {
            InitializeComponent();
        }

        private void frmDovizKurlari_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}