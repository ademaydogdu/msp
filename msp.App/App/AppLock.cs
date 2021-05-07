using DevExpress.XtraEditors;
using Msp.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.App
{
    public partial class AppLock : DevExpress.XtraEditors.XtraForm
    {
        public AppLock()
        {
            InitializeComponent();
        }

        private void AppLock_Load(object sender, EventArgs e)
        {
            txt_UserCode.Text = AppMain.User.username;
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            if (get_Question("Programdan çıkışı onaylıyormusunuz?"))
            {
                Application.Exit();
            }
        }

        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}