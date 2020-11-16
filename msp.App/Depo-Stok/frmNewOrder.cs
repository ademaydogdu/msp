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
using msp.App;
using Msp.Infrastructure;
using Msp.Service.Repository;
using DevExpress.XtraEditors.Controls;
using static Msp.App.Depo_Stok.frmNewOrder.orderRecStatus;
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Utilities;

namespace Msp.App.Depo_Stok
{
    public partial class frmNewOrder : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmNewOrder()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public FormOpenType _FormOpenType;
        private OrderManagementDTO __orders = new OrderManagementDTO();
        List<UnitsDTO> units = new List<UnitsDTO>();
        List<OrderManagementDTO> _ordersList = new List<OrderManagementDTO>();

        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        public void Show(int id)
        {
            units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = units;


            if (_FormOpenType == FormOpenType.Edit)
            {
                __orders = _repository.Run<OrderManagementService, OrderManagementDTO>(x => x.GetOrder(id));
            }

            //taxEditTE.Properties.DataSource = KdvOrani;
            //taxEditTE.Properties.ValueMember = "Id";
            //taxEditTE.Properties.DisplayMember = "Value";

            bs_OrdersReceived.DataSource = __orders;
            this.ShowDialog();
        }



        #region Record


        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(txtStockCode.EditValue) == "")
            {
                XtraMessageBox.Show("Stok Kodu Bilgisi Girilmesi Zorunludur..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((int)(txtAmount.EditValue) == 0)
            {
                XtraMessageBox.Show("Miktar Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((decimal)(txtPrice.EditValue) == 0)
            {
                XtraMessageBox.Show("Fiyat Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((int)txtTaxStatusLE.EditValue == 0)
            {
                XtraMessageBox.Show("KDV Durumu Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((decimal)txtPrice.EditValue == 0)
            {
                XtraMessageBox.Show("Fiyat Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            if ((int)txtDiscountPercent.EditValue == 0)
            {
                XtraMessageBox.Show("İndirim Oran Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((int)txtDiscount.EditValue == 0)
            {
                XtraMessageBox.Show("İskonto Tutar Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            return _return;
        }


        private void do_save()
        {
            bs_OrdersReceived.EndEdit();
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    
                    var response = _repository.Run<OrderManagementService, ActionResponse<OrderManagementDTO>>(x => x.SaveOrder(__orders));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        
                       
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
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

        public void do_refresh()
        {
            _ordersList = _repository.Run<OrderManagementService, List<OrderManagementDTO>>(x => x.GetListOrder());
            bs_OrdersReceived.DataSource = bs_OrdersReceived;
        }

        #endregion




        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }





        private void frmOrdersReceived_Load(object sender, EventArgs e)
        {
            orderRecStatus cList = new orderRecStatus();
            cList.Add(new CurStatus(0, "Beklemede"));
            cList.Add(new CurStatus(1, "Tamamlandı"));


            oROrderStatusLE.Properties.DataSource = cList;
            oROrderStatusLE.Properties.DisplayMember = "Name";
            oROrderStatusLE.Properties.ValueMember = "Id";

            oROrderStatusLE.Properties.Columns.Add(new LookUpColumnInfo("Id", "ID", 20));
            oROrderStatusLE.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 80));

            oROrderStatusLE.Properties.TextEditStyle = TextEditStyles.Standard;

            do_refresh();

        }



        public class orderRecStatus : System.Collections.CollectionBase
        {
            public CurStatus this[int index]
            {
                get { return (CurStatus)(List[index]); }
                set { List[index] = value; }
            }

            public int Add(CurStatus value)
            {
                return List.Add(value);
            }



            public class CurStatus
            {
                private string name;
                private int id;

                public CurStatus(int _id, string _name)
                {
                    id = _id;
                    name = _name;
                }

                public string Name
                {
                    get { return name; }
                    set { name = value; }
                }

                public int Id
                {
                    get { return id; }
                    set { id = value; }
                }
            }
        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmStok frm = new frmStok();
            this.Show();
     
        }

        private void btnORRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnORSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}