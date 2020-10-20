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

namespace Msp.App.Islemler
{
    public partial class frmBankEntry : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmBankEntry()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<BankEntryDTO> _bankEntries = new List<BankEntryDTO>();

        public void do_refresh()
        {

            _bankEntries = _repository.Run<BankEntryServices, List<BankEntryDTO>>(x => x.GetListBankEntries());
            bs_BankEntry.DataSource = _bankEntries;
        }

        private void frmBankEntry_Load(object sender, EventArgs e)
        {
            repositoryItemLookUpEdit1.DataSource = _repository.Run<BankEntryServices, List<BanksDTO>>(x => x.GetListBanks());
            repositoryItemLookUpEdit1.ValueMember = "Bid";
            repositoryItemLookUpEdit1.DisplayMember = "BankName";
            do_refresh();
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

        #region Edit
        public void do_Edit()
        {
            BankEntryDTO Orow = (BankEntryDTO)gcv_BankEntry.GetFocusedRow();
            if (Orow != null)
            {
                frmBankEntryEdit frm = new frmBankEntryEdit();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(Orow.bid);

            }




        }
        private void btnEditProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Edit();
        }
        #endregion



        private void btnBankEntryRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void btnBankEntryAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBankEntryEdit frm = new frmBankEntryEdit();
            frm._FormOpenType = Msp.Infrastructure.FormOpenType.New;
            frm.Show(0);
        }

        private void btnBankEntryEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BankEntryDTO oRow = (BankEntryDTO)gcv_BankEntry.GetFocusedRow();

            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<BankEntryServices, ActionResponse<BankEntryDTO>>(x => x.DeleteBankEntries(oRow.bid));
                    do_refresh();
                }
            }
        }
    }
}