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
using Msp.Models.Models;
using Msp.Service.Service.Operations;
using Msp.Models.Models.Utilities;

namespace Msp.App.Tanimlar
{

    public partial class frmBankDefinition : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmBankDefinition()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<BanksDTO> _bankDetailsList = new List<BanksDTO>();


        public void do_refresh()
        {

            _bankDetailsList = _repository.Run<BankEntryServices, List<BanksDTO>>(x => x.GetListBanks());
            bs_BankDetails.DataSource = _bankDetailsList;
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

        private bool do_Validation()
        {
            bool _return = false;
            //if (Convert.ToString(bankDefBankNameTE.EditValue) == "")
            //{
            //    XtraMessageBox.Show("Banka Adı Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    _return = true;
            //}
            //if (bankDefBranchName.EditValue == "")
            //{
            //    XtraMessageBox.Show("Şube Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    _return = true;
            //}

            return _return;
        }
        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<BankEntryServices, ActionResponse<List<BanksDTO>>>(x => x.SaveBank(_bankDetailsList));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }


        public void do_Edit()
        {
            BankEntryDTO Orow = (BankEntryDTO)gcv_BankDetails.GetFocusedRow();
            if (Orow != null)
            {

                //bankDefBranchName.EditValue = _bankDetails.BankBranch;
                //bankDefBranchCode.EditValue = _bankDetails.BankBranchCode;
                //bankDefBankNameTE.EditValue = _bankDetails.BankName;
                //bankDefAccNo.EditValue = _bankDetails.BankAccountNumber;
                //bankDefAccName.EditValue = _bankDetails.BankAccountName;
            }

        }



        private void frmBankDefinition_Load(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BanksDTO oRow = (BanksDTO)gcv_BankDetails.GetFocusedRow();
            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    if (oRow.Bid == 0)
                    {
                        _bankDetailsList.Remove(oRow);
                        gridControl1.RefreshDataSource();
                    }
                    else
                    {
                        var result = _repository.Run<BankEntryServices, ActionResponse<BanksDTO>>(x => x.DeleteBank(oRow.Bid));
                        do_refresh();
                    }
              
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}