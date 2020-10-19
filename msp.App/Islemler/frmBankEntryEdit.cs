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
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Service.Service.Operations;
using Msp.Models.Models.Utilities;
using Msp.App.Tanimlar;

namespace Msp.App.Islemler
{
    public partial class frmBankEntryEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository = new Repository();
        public frmBankEntryEdit()
        {
            InitializeComponent();
        }
        public FormOpenType _FormOpenType;

        private BankEntryDTO __bankEntries = new BankEntryDTO();
        List<BanksDTO> banks = new List<BanksDTO>();


        public void Show(int id)
        {
            banks = _repository.Run<BankEntryServices, List<BanksDTO>>(x => x.GetListBanks());
            bs_BankEntries.DataSource = banks;

            if (_FormOpenType == FormOpenType.Edit)
            {
                __bankEntries = _repository.Run<BankEntryServices, BankEntryDTO>(x => x.GetBankEntries(id));
            }

            bs_BankEntries.DataSource = __bankEntries;
            this.ShowDialog();
        }

        #region Record


        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(bankNameTE.EditValue) == "")
            {
                XtraMessageBox.Show("Banka Adı Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (docDescTE.EditValue == "")
            {
                XtraMessageBox.Show("KDV Oranı Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((int)amountTE.EditValue == 0 || (int)withdrawTE.EditValue == 0)
            {
                XtraMessageBox.Show("Yatan Tutar Veya Çekilen Tutar Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((decimal)docNoTE.EditValue == 0)
            {
                XtraMessageBox.Show("Fiş No İle Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            return _return;
        }


        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {

                    var response = _repository.Run<BankEntryServices, ActionResponse<BankEntryDTO>>(x => x.SaveBankEntries(__bankEntries));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "frmBankEntry")
                            {
                                ((frmBankEntry)item).do_refresh();
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


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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



        private void btnBankEntryClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bankNameTE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmBankDefinition frm = new frmBankDefinition();
                frm.ShowDialog();

                //units = _repository.Run<BankEntryServices, List<BankEntryDTO>>(x => x.GetListBankEntries());
                //bs_Unit.DataSource = units;
            }
        }
    }
}