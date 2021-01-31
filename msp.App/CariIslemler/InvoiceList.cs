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
using Msp.Models.Models.Utilities;
using Msp.Service.Service.CurrentTransactions;
using Msp.Service.Service.Depot;
using Msp.App.Report;

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

        List<SelectIdValue> IceType = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Alım Faturası"),
            new SelectIdValue(2, "Satış Faturasi"),
            new SelectIdValue(4, "Alım İrsaliyesi"),
            new SelectIdValue(5, "Satış İrsaliyesi"),
        };

        public InvoiceType invoice;
        private void InvoiceList_Load(object sender, EventArgs e)
        {
            switch (invoice)
            {
                case InvoiceType.AlımFaturası:
                    this.Text = "Alım Faturası Listesi";
                    break;
                case InvoiceType.SatisFaturasi:
                    this.Text = "Satış Faturası Listesi";
                    break;
                case InvoiceType.AllFatura:
                    this.Text = "Alım/Satış Faturası Listesi";
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    break;
                case InvoiceType.AlisIrsaliye:
                    this.Text = "Alış İrsaliyesi Listesi";
                    break;
                case InvoiceType.SatisIrsaliye:
                    this.Text = "Satış İrsaliyesi Listesi";
                    break;
                case InvoiceType.AllIrsaliye:
                    this.Text = "Alış/Satış İrsaliyesi Listesi";
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    break;
                default:
                    break;
            }
            MspTool.Get_Layout(this);
            do_refresh();

            rp_InvoiceType.DataSource = IceType;
            rp_InvoiceType.ValueMember = "Id";
            rp_InvoiceType.DisplayMember = "Value";

            var _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            rp_cari.DataSource = _currentTransactionsList;
            rp_cari.ValueMember = "CurID";
            rp_cari.DisplayMember = "CurAccountName";

            var _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            rp_depot.DataSource = _depotList;
            rp_depot.ValueMember = "DID";
            rp_depot.DisplayMember = "DepName";
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
                invoiceList = _repository.Run<InvoiceService, List<InvoiceOwnerDTO>>(x => x.GetList_Invoice((int)invoice));
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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceOwnerDTO oRow = (InvoiceOwnerDTO)gcv_Invoice.GetFocusedRow();
            if (oRow != null)
            {
                var response = _repository.Run<InvoiceService, ActionResponse<InvoiceOwnerDTO>>(x => x.Deleted_InvoiceOwner(oRow.RecId));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    do_refresh();
                }
            }
        }

        private void btnCurTranClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceOwnerDTO oRow = (InvoiceOwnerDTO)gcv_Invoice.GetFocusedRow();
            if (oRow != null)
            {
                oRow._invoiceTrans = _repository.Run<InvoiceService, List<InvoiceTransDTO>>(x => x.Get_Edit_List_Trans(oRow.RecId));
                frmPrint frm = new frmPrint();
                frm.PrintInvoiceReport(oRow);
                frm.ShowDialog();
            }
        }
    }
}