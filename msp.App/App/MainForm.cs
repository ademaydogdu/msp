using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Msp.App.App;
using Msp.Infrastructure;

namespace msp.App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Method
        public bool IsConnected()
        {
            System.Uri Url = new System.Uri("http://www.google.com");
            System.Net.WebRequest WebReq;
            System.Net.WebResponse Resp;
            WebReq = System.Net.WebRequest.Create(Url);
            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                return true;
            }
            catch
            {
                WebReq = null;
                return false;
            }
        }
        #endregion

        #region Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login loForm = new Login();
            loForm.TopMost = true;
            loForm.ShowDialog();

            if (AppMain.User != null)
            {

            }
            else
            {
                Application.ExitThread();
            }





        }

        #endregion



        #region Bar_Buton



        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSatis frm = new frmSatis();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStok frm = new frmStok();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem63_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #endregion


    }
}