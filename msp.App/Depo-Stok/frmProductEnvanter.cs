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
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Utilities;

namespace Msp.App.Depo_Stok
{
    public partial class frmProductEnvanter : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmProductEnvanter()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool mspTool = new MspTool();
        List<ProductDTO> _productlist = new List<ProductDTO>();


        #region Record

        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(comboBoxEdit1.EditValue) == "")
            {
                XtraMessageBox.Show("Ürün Ekle/Çıkar Boş Bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (Convert.ToString(txt_Miktar.EditValue) == "")
            {
                XtraMessageBox.Show("Miktar Giriniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (Convert.ToString(lb_ProductName.EditValue) == "")
            {
                XtraMessageBox.Show("Ürün Adı Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            return _return;
        }
        public void do_save()
        {
            bs_products.EndEdit();
            if (do_Validation()) return;
            if (mspTool.get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {

                    ProductDTO newProduct = _productlist.Where(x => x.PID == (int)lb_ProductName.EditValue).FirstOrDefault();
                    if (Convert.ToString(comboBoxEdit1.EditValue) == "Ekle")
                    {
                        newProduct.PTotal = newProduct.PTotal + Convert.ToDecimal(txt_Miktar.EditValue);
                    }
                    else
                    {
                        if (newProduct.PTotal != 0)
                            newProduct.PTotal = newProduct.PTotal - Convert.ToDecimal(txt_Miktar.EditValue);
                    }

                    var response = _repository.Run<DepotStockService, ActionResponse<ProductDTO>>(x => x.SaveProduct_EnvanterEkle(newProduct));
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




        #endregion

        private void frmProductEnvanter_Load(object sender, EventArgs e)
        {
            mspTool.Get_Layout(this);

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;
        }

        private void frmProductEnvanter_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Get_Layout(this);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmProductEnvanter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}