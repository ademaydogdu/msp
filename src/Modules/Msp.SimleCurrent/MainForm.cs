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
using Msp.SimleCurrent.Screen;

namespace Msp.SimleCurrent
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public MainForm(string ConnectionString)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bbi_HesapTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSimleCurrentDefinitionList frn = new frmSimleCurrentDefinitionList();
            frn.MdiParent = this;
            frn.Show();
        }

        private void btnHizliFaturaGirisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSpeedInvoice frm = new frmSpeedInvoice();
            frm.ShowDialog();
        }

        private void btnAlimFaturasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceList frm = new InvoiceList();
            frm.invoice = Models.InvoiceType.AlisFaturasi;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSatisFaturasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceList frm = new InvoiceList();
            frm.invoice = Models.InvoiceType.SatisFaturasi;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}