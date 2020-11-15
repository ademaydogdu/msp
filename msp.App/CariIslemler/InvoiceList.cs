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
using Msp.Models.Models.Invoice;
using Msp.Service.Service.Invoice;

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
        List<InvoiceOwnerDTO> invoiceList = new List<InvoiceOwnerDTO>();


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
            do_refresh();
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

        public void do_refresh()
        {
            try
            {
                invoiceList = _repository.Run<InvoiceService, List<InvoiceOwnerDTO>>(x=>x.GetList_Invoice((int)invoice));
                bs_Invoice.DataSource = invoiceList;
            }
            catch (Exception)
            {
            }
        }


        private void btnNewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceEdit frm = new InvoiceEdit();
            frm.MdiParent = this.MdiParent;
            frm.invoice = invoice;
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.Show();
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void btnEditAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceOwnerDTO oRow = (InvoiceOwnerDTO)gcv_Invoice.GetFocusedRow();
            if (oRow != null)
            {
                InvoiceEdit frm = new InvoiceEdit();
                frm.MdiParent = this.MdiParent;
                frm.invoice = invoice;
                frm._FormOpenType = FormOpenType.Edit;
                frm.RecId = oRow.RecId;
                frm.Show(); 
            }
        }
    }
}