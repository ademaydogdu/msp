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
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models.Utilities;
using Msp.Models.Models.Order;
using Msp.Service.Service.Order;

namespace Msp.App.CariIslemler
{
    public partial class OrderList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public OrderList()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        MspTool MspTool = new MspTool();
        public OrderType orderType;

        List<OrderOwnerDTO> List_OrderOwner = new List<OrderOwnerDTO>();

        List<SelectIdValue> OrdType = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Alış Sipariş"),
            new SelectIdValue(2, "Satış Sipariş"),
            new SelectIdValue(5, "Bekleyen Sipariş"),
        };

        #region Record

        public void do_refresh()
        {
            try
            {
                List_OrderOwner = _repository.Run<OrderService, List<OrderOwnerDTO>>(x => x.GetList_Order((int)orderType));
                bs_OrderList.DataSource = List_OrderOwner;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "HATA" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion

        #region Form
        private void OrderList_Load(object sender, EventArgs e)
        {

            switch (orderType)
            {
                case OrderType.AlisSiparis:
                    this.Text = "Alış Sipariş Listesi";
                    break;
                case OrderType.SatisSiparis:
                    this.Text = "Satış Sipariş Listesi";
                    break;
                case OrderType.AllSiparis:
                    this.Text = "Alış/Satış Sipariş Listesi";
                    break;
                case OrderType.BekleyenSiparis:
                    this.Text = "Bekleyen Siparişler";
                    break;
                default:
                    break;
            }
            MspTool.Get_Layout(this);
            do_refresh();
        }

        private void OrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void OrderList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        } 
        #endregion
    }
}