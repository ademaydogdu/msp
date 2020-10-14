using DevExpress.Office.Utils;
using DevExpress.Utils.CommonDialogs;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using Msp.App.Tanimlar;
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.DepotStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Depo_Stok
{
    public partial class frmStockEdit : XtraForm
    {
        Repository _repository = new Repository();

        public frmStockEdit()
        {
            InitializeComponent();
        }

        public FormOpenType _FormOpenType;

        private ProductDTO __product = new ProductDTO();
        List<UnitsDTO> units = new List<UnitsDTO>();

        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),


        };


        //public void calculateTotalPrice()
        //{
        //    bool __return = false;



        //    decimal fPrice, taxVal = 0;
        //    fPrice = Convert.ToInt32(firstPriceTextEdit.SelectedText);
        //    taxVal = Convert.ToInt32(taxTextEdit.GetSelectedDataRow();
        //    var TotalPrice = fPrice + (fPrice * taxVal / 100);
        //    lastPriceTextEdit.Text = Convert.ToString(TotalPrice);


        //}

        public void Show(int id)
        {
            units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = units;

            if (_FormOpenType == FormOpenType.New)
            {
                __product = new ProductDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(id));
            }

            taxTextEdit.Properties.DataSource = KdvOrani;
            taxTextEdit.Properties.ValueMember = "Id";
            taxTextEdit.Properties.DisplayMember = "Value";

            bs_StockEdit.DataSource = __product;
            this.ShowDialog();
        }

        #region Record


        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(nameTextEdit.EditValue) == "")
            {
                XtraMessageBox.Show("Ürün Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (Convert.ToString(taxTextEdit.EditValue) == "")
            {
                XtraMessageBox.Show("KDV Oranı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if ((int)UnittextEdit.EditValue == 0)
            {
                XtraMessageBox.Show("Birim Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            return _return;
        }


        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {

                    var response = _repository.Run<DepotStockService, ActionResponse<ProductDTO>>(x => x.SaveProduct(__product));
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







        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        #endregion


        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            do_save();
        }

        private void UnittextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmBirimTanim frm = new frmBirimTanim();
                frm.ShowDialog();

                units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
                bs_Unit.DataSource = units;
            }
        }










        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }
        private void frmStockEdit_Load(object sender, EventArgs e)
        {
            // StockEditPE.DataBindings.Add("EditValue", bs_StockEdit, "image");
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fileDialog.RestoreDirectory = true;
            fileDialog.FilterIndex = 2;
            fileDialog.InitialDirectory = desktopPath;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                StockEditPE.Image = Image.FromFile(filePath);
                // byte[] newImg = (byte[])StockEditPE.EditValue;

            }
        }

    }

}