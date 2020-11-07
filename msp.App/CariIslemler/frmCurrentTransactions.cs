using DevExpress.XtraEditors;
using Msp.Models.Models;
using Msp.Service.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Msp.Service.Service.CurrentTransactions;
using Msp.App.CariIslemler;
using Msp.Models.Models.Utilities;
using Msp.App.Tool;

namespace msp.App
{
    public partial class frmCurrentTransactions : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmCurrentTransactions()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();
        MspTool mspTool = new MspTool();

        private void CurrentTransactions_Load(object sender, EventArgs e)
        {
            do_refresh();

            mspTool.Get_GridControl(this.Name, gcvCurTransaction);

        }

        public void do_refresh()
        {

            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            CurTranBindingSource.DataSource = _currentTransactionsList;
        }


        #region Edit
        public void do_Edit()
        {
            CTransactionsDTO Orow = (CTransactionsDTO)gcv_CurTrans.GetFocusedRow();
            if (Orow != null)
            {
                frmCurTranEdit frm = new frmCurTranEdit();
                frm._FormOpenType = Msp.Infrastructure.FormOpenType.Edit;
                frm.Show(Orow.CurID);
            }
        }

        #endregion


        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        private void btnRemAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CTransactionsDTO oRow = (CTransactionsDTO)gcv_CurTrans.GetFocusedRow();

            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<CurrentTransactionsService, ActionResponse<CTransactionsDTO>>(x => x.DeleteCurrentCustomer(oRow.CurID));
                    do_refresh();
                }
            }
        }

        private void btnNewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCurTranEdit frm = new frmCurTranEdit();
            frm._FormOpenType = Msp.Infrastructure.FormOpenType.New;
            frm.Show(0);
        }

        private void btnEditAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Edit();
        }

        private void frmCurrentTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gcvCurTransaction);
        }
    }
}
