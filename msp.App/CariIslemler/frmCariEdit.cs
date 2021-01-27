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
        private CTransactionsDTO __cTransaction = new CTransactionsDTO();
        List<CaseMovementDTO> _List_CaseMov = new List<CaseMovementDTO>();

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
            if (CurPhoneOneTextEdit.EditValue ==  "")
            {
                XtraMessageBox.Show("Telefon Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            return _return;
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


        private void frmCariEdit_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);

            if (_FormOpenType == FormOpenType.Edit)
            {
                __cTransaction = _repository.Run<CurrentTransactionsService, CTransactionsDTO>(x => x.GetCurrentTransaction(RecId));
                _List_CaseMov = _repository.Run<CaseService, List<CaseMovementDTO>>(x => x.Get_List_CaseMovement_CariId(AppMain.CompanyRecId, RecId));
                bs_CaseMov.DataSource = _List_CaseMov;
            }
            CurTranBindingSource.DataSource = __cTransaction;

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
    }
}