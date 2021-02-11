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
using Msp.Models.Models.Order;
using Msp.Service.Service.Report;

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
        List<OrderOwnerDTO> List_OrderOwner = new List<OrderOwnerDTO>();

        #region Record

        private void do_report(bool report)
        {
            try
            {
                var req = new Models.Models.Report.OrderRequest
                {
                    OrderType = (int)orderFilter,
                    BeginDate = dt_BeginDate.DateTime,
                    EndDate = new DateTime(dt_EndDate.DateTime.Year, dt_EndDate.DateTime.Month, dt_EndDate.DateTime.Day, 23, 59, 00),
                };
                if (orderFilter == OrderFilter.Siparis)
                {
                    List_OrderOwner = _repository.Run<ReportService, List<OrderOwnerDTO>>(x => x.GetList_Order(req));
                    if (List_OrderOwner.Count > 0)
                    {
                        gridControl1.DataSource = List_OrderOwner;
                        if (report)
                        {
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Kayıt Bulunamadı...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                if (orderFilter == OrderFilter.SevkRapor)
                {
                    List_OrderOwner = _repository.Run<ReportService, List<OrderOwnerDTO>>(x => x.GetList_OrderSevk(req));
                    if (List_OrderOwner.Count > 0)
                    {
                        gridControl1.DataSource = List_OrderOwner;
                        if (report)
                        {
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Kayıt Bulunamadı...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }


            }
            catch (Exception)
            {
            }
        }


        #endregion


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
            dt_BeginDate.EditValue = DateTime.Today;
            dt_EndDate.EditValue = DateTime.Today;

        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            do_report(false);
        }
    }
}