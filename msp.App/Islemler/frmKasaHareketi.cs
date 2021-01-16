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
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models.Case;
using Msp.Service.Repository;
using Msp.Service.Service.Case;
using Msp.Models.Models.Utilities;
using Msp.Models.Models;
using Msp.Service.Service.Tanimlar;
using Msp.App.Tanimlar;
using Msp.Service.Service.CurrentTransactions;

namespace Msp.App.Islemler
{
    public partial class frmKasaHareketi : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmKasaHareketi()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        MspTool mspTool = new MspTool();
        public FormOpenType _FormOpenType;
        List<CaseDefinitionDTO> __List_CaseDef = new List<CaseDefinitionDTO>();
        List<PaymentTypeDTO> _list_PaymnetType = new List<PaymentTypeDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();
        List<CashPayGroupDefDTO> cashGroup = new List<CashPayGroupDefDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();


        List<SelectIdValue> IslemTuru = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Gider"),
            new SelectIdValue(2, "Gelir")
        };

        CaseMovementDTO _CaseMovement;

        private void do_CaseRefresh()
        {
            __List_CaseDef = _repository.Run<DefinitionsService, List<CaseDefinitionDTO>>(x => x.Get_List_CaseDef(AppMain.CompanyRecId));
            bs_CaseList.DataSource = __List_CaseDef;
        }

        private void do_OdemeTuru()
        {

            _list_PaymnetType = _repository.Run<DefinitionsService, List<PaymentTypeDTO>>(x => x.GetListPayments());
            bs_PaymentType.DataSource = _list_PaymnetType;
        }

        public void do_cashGroup()
        {
            cashGroup = _repository.Run<DefinitionsService, List<CashPayGroupDefDTO>>(x => x.Get_List_CashPayGroup());
            bs_CashPayGroupDef.DataSource = cashGroup;
        }

        public void Show(int RecId)
        {
            if (_FormOpenType == FormOpenType.New)
            {
                _CaseMovement = new CaseMovementDTO();
                _CaseMovement.RecordDate = DateTime.Now;
                _CaseMovement.RecordUser = AppMain.User.username;
                _CaseMovement.CompanyRecId = AppMain.CompanyRecId;

            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                _CaseMovement = _repository.Run<CaseService, CaseMovementDTO>(x => x.Get_CaseMovement(RecId));
            }
            if (_FormOpenType == FormOpenType.Copy)
            {
                _CaseMovement = _repository.Run<CaseService, CaseMovementDTO>(x => x.Get_CaseMovement(RecId));
                _CaseMovement.RecId = 0;
            }

            cbb_IslemTuru.Properties.DataSource = IslemTuru;
            cbb_IslemTuru.Properties.ValueMember = "Id";
            cbb_IslemTuru.Properties.DisplayMember = "Value";


            do_CaseRefresh();
            do_OdemeTuru();
            do_cashGroup();

            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;


            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;


            bs_CaseMov.DataSource = _CaseMovement;
            this.ShowDialog();
        }

        #region Record

        public bool do_Validation()
        {
            bool _return = false;
            return _return;
        }

        public void do_save()
        {
            bs_CaseMov.EndEdit();
            if (do_Validation()) return;
            if (mspTool.get_Question("Kaydı Onaylıyor musunuz?"))
            {
                try
                {
                    var response = _repository.Run<CaseService, ActionResponse<CaseMovementDTO>>(x => x.SaveCaseMovement(_CaseMovement));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "frmKasaHareketList")
                            {
                                ((frmKasaHareketList)item).do_refresh();
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



        #endregion


        private void frmKasaHareketi_Load(object sender, EventArgs e)
        {
            mspTool.Get_Layout(this);
        }

        private void frmKasaHareketi_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void frmKasaHareketi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void lc_CaseDef_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmCaseDefinition frm = new frmCaseDefinition();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    do_CaseRefresh();
                }
            }
        }

        private void lc_OdemeTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmPaymnetList frm = new frmPaymnetList();
                    frm.ShowDialog();

                }
                catch (Exception ex)
                {
                }
                finally
                {
                    do_OdemeTuru();
                }
            }
        }

        private void lc_OdemeGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    CashPayGroupDef frm = new CashPayGroupDef();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    do_cashGroup();
                }
            }
       
        }
    }
}