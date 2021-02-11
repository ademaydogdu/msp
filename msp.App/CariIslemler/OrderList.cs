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
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.CurrentTransactions;
using Msp.Service.Service.App;
using Msp.Service.Service.Tanimlar;

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
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();
        List<CurrencyTypeDTO> _currencyTypes = new List<CurrencyTypeDTO>();
        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };


        List<SelectIdValue> OrdType = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Alış Sipariş"),
            new SelectIdValue(2, "Satış Sipariş"),
            new SelectIdValue(5, "Bekleyen Sipariş"),
        };

        List<SelectIdValue> teklifSiparis = new List<SelectIdValue>()
        {
            new SelectIdValue(0, "Sipariş"),
            new SelectIdValue(1, "Teklif"),
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
            finally
            {
            }
        }
        private void do_edit()
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Update, (int)DocumentType.Order, AppMain.CompanyRecId))
            {
                return;
            }
            OrderOwnerDTO oRow = (OrderOwnerDTO)gcv_OrderList.GetFocusedRow();
            if (oRow.IrsaliyeId > 0) { XtraMessageBox.Show("Kayıt İrsaliyeleştirilmiştir. İşlem Yapılamaz. Ön İzleme ile açılabilir...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (oRow != null)
            {
                OrderEdit frm = new OrderEdit();
                frm.MdiParent = this.MdiParent;
                frm._FormOpenType = FormOpenType.Edit;
                frm.RecId = oRow.RecId;
                frm.OrderType = orderType;
                frm.Show();
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


            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = _list_UnitsDTO;

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_Product.DataSource = _productlist;

            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;

            _company = _repository.Run<StartUp, List<CompanyDTO>>(x => x.GetList_Company());
            bs_company.DataSource = _company;

            _currencyTypes = _repository.Run<DefinitionsService, List<CurrencyTypeDTO>>(x => x.Get_List_CurrencyType());
            bs_CurrencyType.DataSource = _currencyTypes;

            rp_OrderType.DataSource = OrdType;
            rp_OrderType.ValueMember = "Id";
            rp_OrderType.DisplayMember = "Value";

            rp_TeklifSiparis.DataSource = teklifSiparis;
            rp_TeklifSiparis.ValueMember = "Id";
            rp_TeklifSiparis.DisplayMember = "Value";

            //rp_.DataSource = KdvOrani;
            //rp_KDV.ValueMember = "Id";
            //rp_KDV.DisplayMember = "Value";



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

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Insert, (int)DocumentType.Order, AppMain.CompanyRecId))
            {
                return;
            }
            OrderEdit frm = new OrderEdit();
            frm.MdiParent = this.MdiParent;
            frm._FormOpenType = FormOpenType.New;
            frm.RecId = 0;
            frm.OrderType = orderType;
            frm.Show();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_edit();
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Delete, (int)DocumentType.Order, AppMain.CompanyRecId))
            {
                return;
            }
            OrderOwnerDTO oRow = (OrderOwnerDTO)gcv_OrderList.GetFocusedRow();
            if (oRow != null)
            {
                if (MspTool.get_Question("Kayıt Silincektir. Onaylıyor musunuz?"))
                {
                    var response = _repository.Run<OrderService, ActionResponse<OrderOwnerDTO>>(x => x.Deleted_Order(oRow.RecId));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        do_refresh();
                    } 
                }
            }
        }

        private void gcv_OrderList_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            int IrsaliyeId = Convert.ToInt32(gcv_OrderList.GetRowCellValue(e.RowHandle, colIrsaliyeId));
            if (IrsaliyeId > 0)
            {
                e.Appearance.BackColor = Color.LightBlue;
            }

        }

        private void bbi_View_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Preview, (int)DocumentType.Order, AppMain.CompanyRecId))
            {
                return;
            }
            OrderOwnerDTO oRow = (OrderOwnerDTO)gcv_OrderList.GetFocusedRow();
            if (oRow != null)
            {
                OrderEdit frm = new OrderEdit();
                frm.MdiParent = this.MdiParent;
                frm._FormOpenType = FormOpenType.View;
                frm.RecId = oRow.RecId;
                frm.OrderType = orderType;
                frm.Show();
            }
        }

        private void gcv_OrderList_DoubleClick(object sender, EventArgs e)
        {
            do_edit();
        }
    }
}