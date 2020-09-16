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
    }
}
