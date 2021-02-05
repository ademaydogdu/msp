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
using Msp.Service.Service.CurrentTransactions;
using Msp.Models.Models.Utilities;
using Msp.Models.Models.Case;
using Msp.Service.Service.Case;
using Msp.Models.Models.Order;
using Msp.Service.Service.Order;
using Msp.Service.Service.Invoice;
using Msp.Models.Models.Invoice;
using msp.App;
using Msp.Service.Service.DepotStock;
using Msp.App.Tanimlar;

namespace Msp.App.CariIslemler
{
    public partial class frmCariEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmCariEdit()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        public FormOpenType _FormOpenType;

        MspTool MspTool = new MspTool();
        private CTransactionsDTO __cTransaction;
        List<CaseMovementDTO> _List_CaseMov;
        List<CurrentGroupDefinitionsDTO> __CurrentGroupDefinitions = new List<CurrentGroupDefinitionsDTO>();

        List<ShippingInformationDTO> __shippingInformations = new List<ShippingInformationDTO>();
        public int RecId;

        #region Record

        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<CurrentTransactionsService, ActionResponse<CTransactionsDTO>>(x => x.SaveCurrrentCustomer(__cTransaction));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "frmCurrentTransactions")
                            {
                                ((frmCurrentTransactions)item).do_refresh();
                            }
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(ItemForCurCode.Text) == "")
            {
                XtraMessageBox.Show("Cari Kodu Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (ItemForCurAccountName.Text == "")
            {
                XtraMessageBox.Show("Cari Adı Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (CurPhoneOneTextEdit.EditValue == "")
            {
                XtraMessageBox.Show("Telefon Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            return _return;
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

        #endregion

        public void do_refreshCaseMov()
        {
            _List_CaseMov = _repository.Run<CaseService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement_CariId(AppMain.CompanyRecId, RecId));
            bs_CaseMov.DataSource = _List_CaseMov;
        }
        public void do_CurrentGroupDefinitions()
        {
            __CurrentGroupDefinitions = _repository.Run<DepotStockService, List<CurrentGroupDefinitionsDTO>>(x => x.Get_List_CurrentGroupDefinitions());
            bs_CurrentGroupDefinitions.DataSource = __CurrentGroupDefinitions;
        }

        public void Show(int _RecId)
        {
            RecId = _RecId;


            if (_FormOpenType == FormOpenType.New)
            {
                __cTransaction = new CTransactionsDTO();
                __cTransaction.CurCreatedDate = DateTime.Now;
                br_Fatura.Enabled = false;
                br_Irsaliye.Enabled = false;
                br_Siparis.Enabled = false;
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __cTransaction = _repository.Run<CurrentTransactionsService, CTransactionsDTO>(x => x.GetCurrentTransaction(_RecId));
            }
            bs_CTrans.DataSource = __cTransaction;
            do_CurrentGroupDefinitions();



            MspTool.Get_Layout(this);

            this.ShowDialog();
        }

        private void frmCariEdit_Load(object sender, EventArgs e)
        {


        }

        private void frmCariEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (e.Page == tb_bekleyenSiparis)
            {
                var _order = _repository.Run<OrderService, List<OrderOwnerDTO>>(x => x.GetList_OrderWait_CariId(RecId));
                bs_OrderList.DataSource = _order;
            }
            if (e.Page == tb_bekleyenIrsaliye)
            {
                var _Invoice = _repository.Run<InvoiceService, List<InvoiceOwnerDTO>>(x => x.GetList_FindIrsaliye_CariId((int)RecId));
                bs_Invoice.DataSource = _Invoice;
            }
            if (e.Page == tb_bakiye)
            {
                do_refreshCaseMov();
            }
        }

        private void bbi_AlisIrsaliye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceEdit frm = new InvoiceEdit();
            frm.invoice = InvoiceType.AlisIrsaliye;
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.CariId = RecId;
            frm.ShowDialog();
        }

        private void bbi_SatisIrsaliye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceEdit frm = new InvoiceEdit();
            frm.invoice = InvoiceType.SatisIrsaliye;
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.CariId = RecId;
            frm.ShowDialog();
        }

        private void bbi_AlimFaturasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceEdit frm = new InvoiceEdit();
            frm.invoice = InvoiceType.AlımFaturası;
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.CariId = RecId;
            frm.ShowDialog();
        }

        private void bbi_SatisFaturasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceEdit frm = new InvoiceEdit();
            frm.invoice = InvoiceType.SatisFaturasi;
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.CariId = RecId;
            frm.ShowDialog();
        }

        private void bbi_AlisSiparis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrderEdit frm = new OrderEdit();
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.OrderType = OrderType.AlisSiparis;
            frm.CariId = RecId;
            frm.ShowDialog();
        }

        private void bbi_SiparisSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrderEdit frm = new OrderEdit();
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.OrderType = OrderType.SatisSiparis;
            frm.CariId = RecId;
            frm.ShowDialog();
        }

        private void lc_CariGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    CurrentGroupDefinitions frm = new CurrentGroupDefinitions();
                    frm.ShowDialog();
                }
                catch (Exception)
                {
                }
                finally
                {
                    do_CurrentGroupDefinitions();
                }
            }
        }
    }
}