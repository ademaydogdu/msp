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
using Msp.Service.Service.CustomerTransactions;
using Msp.Models.Models;

namespace Msp.App.App
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public Dashboard()
        {
            InitializeComponent();
            _repository = new Repository();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var customerCount = _repository.Run<CustomerTransactionsService, List<CustomersDTO>>(x => x.GetListCustomer());
            lblCustomerCount.Text = Convert.ToString(customerCount.Count());
        }
    }
}