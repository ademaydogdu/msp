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
using System.Data.EntityClient;


namespace msp.App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //    }
        //}

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
    }
}