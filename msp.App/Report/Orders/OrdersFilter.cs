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
using Msp.App.Tool;
using Msp.Models.Models.Invoice;
using Msp.Infrastructure;
using Msp.Models.Models.Utilities;

namespace Msp.App.Report
{
    public partial class OrdersFilter : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public OrdersFilter()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        public OrderFilter orderFilter;

        MspTool MspTool = new MspTool();

        private void FaturaFilter_Load(object sender, EventArgs e)
        {
            switch (orderFilter)
            {
                case OrderFilter.Siparis:
                    this.Text = "Sipariş & Teklif Rapor";
                    break;
                case OrderFilter.SevkRapor:
                    this.Text = "Sipariş Sevk Raporları";
                    break;
                default:
                    break;
            }
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}