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

        private void CurrentTransactions_Load(object sender, EventArgs e)
        {
            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetCurrentTransactions());
            CurTranBindingSource.DataSource = _currentTransactionsList;
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

        #region Form_Button




        #endregion

        private void btnRemAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnNewAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCurTranEdit frm = new frmCurTranEdit();
            frm.ShowDialog();
        }
    }
}
