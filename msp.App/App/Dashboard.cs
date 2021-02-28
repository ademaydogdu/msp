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
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.Dashboard;
using Msp.Models.Models.Sale;
using System.Globalization;
using Msp.Models.Models.Dashboard;

namespace Msp.App.App
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public Dashboard()
        {
            InitializeComponent();
            _repository = new Repository();
            set_Form();
        }

        private void set_Form()
        {
            var weekSaleOwner = _repository.Run<DashboardService, List<SaleWeekListDTO>>(x => x.GetList_WeekSaleOwner());
            bs_SaleOwnerWeek.DataSource = weekSaleOwner;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            DateTime BeginDate = DateTime.Now.AddDays(-7);
            DateTime EndDate = DateTime.Now;
            layoutControlGroup1.Text = "Haftalık Satış Listesi " + Convert.ToString(BeginDate.ToShortDateString()) + "-" + Convert.ToString(EndDate.ToShortDateString());

            var customerCount = _repository.Run<CustomerService, List<CustomersDTO>>(x => x.GetListCustomer());
            lblCustomerCount.Text = customerCount.Count() == 0 ? "0" : Convert.ToString(customerCount.Count());

            var Product = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            lblProductCount.Text = Product.Count() == 0 ? "0" : Convert.ToString(Product.Count());

            var SaleOwner = _repository.Run<DashboardService, List<SaleOwnerDTO>>(x => x.GetList_SaleOwner());
            lblTotalCiro.Text = string.Format(CultureInfo.CreateSpecificCulture("tr-TR"), "{0:C}", SaleOwner.Sum(x => x.TotalPrice));

 

        }
    }
}