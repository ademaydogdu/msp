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

namespace Msp.App.Report.CariHesap
{
    public partial class frmCariHesapEkstreFilter : DevExpress.XtraEditors.XtraForm
    {
        public frmCariHesapEkstreFilter()
        {
            InitializeComponent();
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmCariHesapEkstreFilter_Load(object sender, EventArgs e)
        {

        }
    }
}