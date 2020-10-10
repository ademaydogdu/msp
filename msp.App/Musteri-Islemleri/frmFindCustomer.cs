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
using Msp.Service.Service.CustomerTransactions;
using Msp.Models.Models.Utilities;
using Msp.Entity.Entities;
using Msp.Infrastructure;

namespace Msp.App.Musteri_Islemleri
{
    public partial class frmFindCustomer : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmFindCustomer()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        public FormOpenType _FormOpenType;

        private CustomersDTO __customer = new CustomersDTO();

        List<CustomersDTO> _customerList = new List<CustomersDTO>();

        private void frmFindCustomer_Load(object sender, EventArgs e)
        {
            _customerList = _repository.Run<CustomerTransactionsService, List<CustomersDTO>>(x => x.GetListCustomer());
            bs_CustomersSea.DataSource = _customerList;
        }


        private void CustomersSeaNameSurTE_EditValueChanged(object sender, EventArgs e)
        {

            void Show(string name)
            {



                CustomersSeaNameSurTE.Text = name;

                __customer = _repository.Run<CustomerTransactionsService, CustomersDTO>(x => x.GetCustomerFromName(name));
                bs_CustomersSea.DataSource = __customer;
                this.ShowDialog();

            }


        }

    }
}
