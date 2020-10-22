using DevExpress.XtraEditors;
using Msp.App.Tanimlar;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.CurrentTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.CariIslemler
{
    public partial class frmCurTranEdit : XtraForm
    {

        Repository _repository;
        public frmCurTranEdit()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public FormOpenType _FormOpenType;

        private CTransactionsDTO __CTransaction = new CTransactionsDTO();


        List<CTransactionsDTO> __CTransactionList = new List<CTransactionsDTO>();

        public void Show(int id)
        {


            if (_FormOpenType == FormOpenType.New)
            {
                __CTransaction = new CTransactionsDTO();

            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __CTransaction = _repository.Run<CurrentTransactionsService, CTransactionsDTO>(x => x.GetCurrentTransaction(id));
            }


            bs_CurTransactionSource.DataSource = __CTransaction;
            this.ShowDialog();
        }

        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(CurTransEditAccNameTE.EditValue) == "")
            {
                XtraMessageBox.Show("Hesap Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditAccAuthTE.EditValue) == "")
            {
                XtraMessageBox.Show("Yetkili Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditAdressTE.EditValue) == "")
            {
                XtraMessageBox.Show("Adres Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditDistrictTE.EditValue) == "")
            {
                XtraMessageBox.Show("İlçe Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditCityTE.EditValue) == "")
            {
                XtraMessageBox.Show("İl Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if (Convert.ToString(CurTransEditPhoneTE.EditValue) == "")
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

        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<CurrentTransactionsService, ActionResponse<CTransactionsDTO>>(x => x.SaveCurrrentCustomer(__CTransaction));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                       
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCurTranEditSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void btnCurTranEditClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
