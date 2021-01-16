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
using Msp.Service.Repository;
using Msp.App.Tool;
using Msp.Models.Models.Case;
using Msp.Service.Service.Case;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Tanimlar;
using Msp.Service.Service.CurrentTransactions;

namespace Msp.App.Islemler
{
    public partial class frmKasaHareketList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmKasaHareketList()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool mspTool = new MspTool();
        List<CaseMovementDTO> _List_CaseMov = new List<CaseMovementDTO>();
        List<CaseDefinitionDTO> __List_CaseDef = new List<CaseDefinitionDTO>();
        List<PaymentTypeDTO> _list_PaymnetType = new List<PaymentTypeDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();
        List<CashPayGroupDefDTO> cashGroup = new List<CashPayGroupDefDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();

        List<SelectIdValue> IslemTuru = new List<SelectIdValue>()
        {
              new SelectIdValue(1, "Gelir"),
              new SelectIdValue(2, "Gider")
        };

        #region Record

        public void do_refresh()
        {
            _List_CaseMov = _repository.Run<CaseService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement(AppMain.CompanyRecId));
            bs_CaseMov.DataSource = _List_CaseMov;
        }


        #endregion


        private void frmKasaHareketList_Load(object sender, EventArgs e)
        {
            __List_CaseDef = _repository.Run<DefinitionsService, List<CaseDefinitionDTO>>(x => x.Get_List_CaseDef(AppMain.CompanyRecId));
            bs_CaseList.DataSource = __List_CaseDef;
            _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());
            bs_PaymentType.DataSource = _list_PaymnetType;
            cashGroup = _repository.Run<DefinitionsService, List<CashPayGroupDefDTO>>(x => x.Get_List_CashPayGroup());
            bs_CashPayGroupDef.DataSource = cashGroup;
            rp_IslemTuru.DataSource = IslemTuru;
            rp_IslemTuru.ValueMember = "Id";
            rp_IslemTuru.DisplayMember = "Value";
            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;
            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;

            do_refresh();
            mspTool.Get_Layout(this);
        }

        private void frmKasaHareketList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void btnCustomerClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasaHareketi frm = new frmKasaHareketi();
            frm._FormOpenType = Infrastructure.FormOpenType.New;
            frm.Show(0);
        }

        private void btnCustomerRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void btnEditCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (CaseMovementDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                frmKasaHareketi frm = new frmKasaHareketi();
                frm._FormOpenType = FormOpenType.Edit;
                frm.Show(oRow.RecId);
            }

        }

        private void btnRemCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (CaseMovementDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                if (mspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<CaseService, ActionResponse<CaseMovementDTO>>(x => x.Delete_Case(oRow));
                    do_refresh();
                }
            }
        }



    }
}