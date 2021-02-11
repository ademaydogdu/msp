﻿using DevExpress.BarCodes;
using DevExpress.Office.Utils;
using DevExpress.Utils.CommonDialogs;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;
using Msp.App.Report;
using Msp.App.Tanimlar;
using Msp.App.Tool;
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.Depot;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.Tanimlar;
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
        MspTool MspTool = new MspTool();
        private ProductDTO __product = new ProductDTO();
        List<UnitsDTO> units = new List<UnitsDTO>();
        byte[] imgbyte;
        List<DepotDTO> _depotList = new List<DepotDTO>();
        List<ProductGroupDTO> productGroup = new List<ProductGroupDTO>();


        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };


        public List<SelectIdValue> BarcodeType = new List<SelectIdValue>
        {
            new SelectIdValue(1, "Standart Barkod - (EAN-13)"),
            new SelectIdValue(2, "Standart Barkod - (EAN-128)"),
            new SelectIdValue(3, "Standart Barkod - (EAN-8)"),
        };

        enum BacodeCaracter
        {
            EAN13 = 1,
            EAN128 = 2,
            EAN8 = 3
        }


        public void Show(int id)
        {
            units = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = units;

            _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            bs_Depot.DataSource = _depotList;

            productGroup = _repository.Run<DefinitionsService, List<ProductGroupDTO>>(x => x.Get_List_ProductGroup());
            bs_UrunGrup.DataSource = productGroup;

            if (_FormOpenType == FormOpenType.New)
            {
                __product = new ProductDTO();
                __product.PDate = DateTime.Now;
                __product.PExpDate = DateTime.Now;
                __product.PCompanyId = AppMain.CompanyRecId;
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __product = _repository.Run<DepotStockService, ProductDTO>(x => x.GetProduct(id));
            }

            taxTextEdit.Properties.DataSource = KdvOrani;
            taxTextEdit.Properties.ValueMember = "Id";
            taxTextEdit.Properties.DisplayMember = "Value";

            lc_BarkodType.Properties.DataSource = BarcodeType;
            lc_BarkodType.Properties.ValueMember = "Id";
            lc_BarkodType.Properties.DisplayMember = "Value";

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
            if ((decimal)firstPriceTextEdit.EditValue == 0)
            {
                XtraMessageBox.Show("Fiyat Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }

            return _return;
        }


        private void do_save()
        {
            bs_StockEdit.EndEdit();
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    if (imgbyte != null)
                    {
                        __product.PImages = imgbyte;
                    }
                    var response = _repository.Run<DepotStockService, ActionResponse<ProductDTO>>(x => x.SaveProduct(__product));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "frmStok")
                            {
                                ((frmStok)item).do_refresh();
                            }
                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                finally
                {
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
            bs_Depot.DataSource = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            bs_UrunGrup.DataSource = _repository.Run<DefinitionsService, List<ProductGroupDTO>>(x => x.Get_List_ProductGroup());
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //var filePath = string.Empty;
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //fileDialog.RestoreDirectory = true;
            //fileDialog.FilterIndex = 2;
            //fileDialog.InitialDirectory = desktopPath;

            //if (fileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = fileDialog.FileName;
            //    StockEditPE.Image = Image.FromFile(filePath);
            //    byte[] newImg = (byte[])StockEditPE.EditValue;
            //}
        }

        private void do_hesapla()
        {

            if (string.IsNullOrEmpty(firstPriceTextEdit.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(taxTextEdit.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtKarPrice.Text))
            {
                return;
            }
            decimal price = (decimal)firstPriceTextEdit.EditValue;
            decimal kdvTutar = 0;
            decimal MalBedeli = 0;
            decimal textMalBedeli = 0;
            decimal SatisFiyati = 0;
            decimal KarTutar = (decimal)txtKarPrice.EditValue;
            price = Math.Round(price, 2);
            if (!chkKDVIstisna.Checked)
            {
                if (rdgDahilHaric.SelectedIndex == 0) //Dahil
                {
                    ////kdvTutar = Math.Round((price / (1 + (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)taxTextEdit.EditValue).TaxOrani) * (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)taxTextEdit.EditValue).TaxOrani), 2);
                    ////MalBedeli = Math.Round((price - kdvTutar), 2);
                    ////textMalBedeli = Math.Round((price - KarTutar - kdvTutar), 2);
                    ////SatisFiyati = Math.Round(MalBedeli + kdvTutar, 2);
                    ///
                    kdvTutar = Math.Round(KarTutar * (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)taxTextEdit.EditValue).TaxOrani, 2);
                    MalBedeli = Math.Round(price, 2);
                    textMalBedeli = Math.Round((KarTutar - kdvTutar), 2);
                    SatisFiyati = Math.Round(KarTutar + kdvTutar, 2);
                }
                else //Hariç
                {

                    kdvTutar = Math.Round(KarTutar * (decimal)KdvOrani.FirstOrDefault(x => x.Id == (int)taxTextEdit.EditValue).TaxOrani, 2);
                    MalBedeli = Math.Round(price, 2);
                    SatisFiyati = Math.Round(MalBedeli + kdvTutar, 2);
                }
            }
            else
            {
                SatisFiyati = KarTutar;
            }
            lblKDVTutar.Text = Convert.ToString(kdvTutar);
            lblMalBedeli.Text = Convert.ToString(textMalBedeli);
            lblSatisFiyati.Text = Convert.ToString(SatisFiyati);
            lblKar.Text = Convert.ToString(KarTutar - price);
            txtSalePrice.EditValue = Convert.ToString(SatisFiyati);

            //__product.PTaxType = (int)rdgDahilHaric.SelectedIndex;
            __product.PSalePrice = SatisFiyati;
            __product.PMalBedeli = textMalBedeli;
            __product.PPaxAmout = kdvTutar;
            __product.PKarPrice = KarTutar;
        }

        private void taxTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (taxTextEdit.EditValue != null && taxTextEdit.EditValue != "")
            {
                do_hesapla();
                lblKdvOrani.Text = taxTextEdit.Text;
            }
        }

        private void rdgDahilHaric_SelectedIndexChanged(object sender, EventArgs e)
        {
            do_hesapla();
        }

        private void firstPriceTextEdit_Leave(object sender, EventArgs e)
        {
            do_hesapla();
        }

        private void chkKDVIstisna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKDVIstisna.Checked)
            {
                lyControlKDVOrani.Enabled = false;
                lytDahilHaric.Enabled = false;
                taxTextEdit.EditValue = 1;
                __product.PTaxType = 1;
                do_hesapla();
            }
            else
            {
                lyControlKDVOrani.Enabled = true;
                lytDahilHaric.Enabled = true;
                __product.PTaxType = 1;
                taxTextEdit.EditValue = 1;
                do_hesapla();
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image to Upload.";
                dlg.Filter = "Image File (*.jpg;*.bmp;*.gif,*.png)|*.jpg;*.bmp;*.gif;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //con = new SqlConnection(connectionString);
                    try
                    {
                        String imageName = dlg.FileName;
                        Bitmap bmp = new Bitmap(imageName);
                        StockEditPE.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                        StockEditPE.Image = (Image)bmp;
                        FileStream fstream = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                        imgbyte = new byte[fstream.Length];
                        fstream.Read(imgbyte, 0, Convert.ToInt32(fstream.Length));
                        fstream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

        }

        private void txtKarPrice_EditValueChanged(object sender, EventArgs e)
        {
            do_hesapla();
        }

        private void frmStockEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void frmStockEdit_Load_1(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Random rakam
            //int sayi = Convert.ToInt32(9999999999999);
            //Random Rnd = new Random();
            //int RandomSayi = Convert.ToInt32(Rnd.Next(0, sayi));
            //txtBarcode.EditValue = Convert.ToString(RandomSayi);
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            //this.pictureEdit1.Image = null;
            //barCodeControl1.BackgroundImage = null;

            BarCode barCode = new BarCode();
            barCode.Symbology = Symbology.EAN13;
            barCode.CodeText = txtBarcode.Text;
            barCode.BackColor = Color.White;
            barCode.ForeColor = Color.Black;
            barCode.RotationAngle = 0;
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            //barCode.Options.QRCode.CompactionMode = QRCodeCompactionMode.Byte;
            //barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            //barCode.Options.QRCode.ShowCodeText = false;
            barCode.DpiX = 72;
            barCode.DpiY = 72;
            barCode.Module = 2f;

            //barCodeControl1.BackgroundImage = barCode.BarCodeImage;
            //this.pictureEdit1.Image = barCode.BarCodeImage;
        }

        private void lc_BarkodType_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lc_BarkodType.EditValue.ToString()))
            {
                if (Convert.ToInt32(lc_BarkodType.EditValue) == (int)BacodeCaracter.EAN13)
                {
                    txtBarcode.Properties.MaxLength = 13;
                }
                if (Convert.ToInt32(lc_BarkodType.EditValue) == (int)BacodeCaracter.EAN8)
                {
                    txtBarcode.Properties.MaxLength = 8;
                }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lc_BarkodType.EditValue.ToString()))
            {
                if (Convert.ToInt32(lc_BarkodType.EditValue) == (int)BacodeCaracter.EAN13)
                {
                    if (txtBarcode.Text.Length > 0)
                    {
                        frmPrint frm = new frmPrint();
                        frm.PrintBarcode_13(__product);
                        frm.ShowDialog();
                    }
                }
                if (Convert.ToInt32(lc_BarkodType.EditValue) == (int)BacodeCaracter.EAN8)
                {
                    if (txtBarcode.Text.Length > 0)
                    {
                        frmPrint frm = new frmPrint();
                        frm.PrintBarcode_8(__product);
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void productGroupTextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmGroupDefinition frm = new frmGroupDefinition();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    productGroup = _repository.Run<DefinitionsService, List<ProductGroupDTO>>(x => x.Get_List_ProductGroup());
                    bs_UrunGrup.DataSource = productGroup;
                }


            }
        }

        private void lookUpEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmDepo frm = new frmDepo();
                    frm.ShowDialog();

                }
                catch (Exception ex)
                {
                }
                finally
                {
                    _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
                    bs_Depot.DataSource = _depotList;
                }
            }
        }

        private void cb_Tevkifat_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Tevkifat.Checked)
            {
                rg_Tevkifat.Visible = true;
                layout_Tevkifat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lc_oranTevkifat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                rg_Tevkifat.Visible = false;
                layout_Tevkifat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lc_oranTevkifat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }

}