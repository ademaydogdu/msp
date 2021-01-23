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

namespace Msp.App.AdminSettings
{
    public partial class frmLicenceKeyUpdate : DevExpress.XtraEditors.XtraForm
    {
        public frmLicenceKeyUpdate()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmLicenceKeyUpdate_Load(object sender, EventArgs e)
        {

        }

        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _licence = txtUrunAnahtari.Text.Trim();
            Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\MSP", true).SetValue("Licence", _licence);
        }

    }
}