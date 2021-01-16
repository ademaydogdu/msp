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

namespace Msp.App.Musteri_Islemleri
{
    public partial class frmBakidenDus : DevExpress.XtraEditors.XtraForm
    {
        public frmBakidenDus()
        {
            InitializeComponent();
        }

        private void frmBakidenDus_Load(object sender, EventArgs e)
        {

        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmBakidenDus_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmBakidenDus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}