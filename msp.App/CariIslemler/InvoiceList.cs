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
using Msp.Infrastructure;
using Msp.Service.Repository;
using Msp.App.Tool;
using Msp.Models.Models;

namespace Msp.App.CariIslemler
{
    public partial class InvoiceList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public InvoiceList()
        {
            InitializeComponent(); 
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        MspTool MspTool = new MspTool();

        public InvoiceType invoice;

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            switch (invoice)
            {
                case InvoiceType.AlımFaturası:
                    this.Text = "Alım Faturası Listesi";
                    break;
                default:
                    break;
            }
            MspTool.Get_Layout(this);
        }

        private void InvoiceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InvoiceList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void btnNewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceEdit frm = new InvoiceEdit();
            frm.MdiParent = this.MdiParent;
            frm.invoice = invoice;
            frm.Show();
        }
    }
}