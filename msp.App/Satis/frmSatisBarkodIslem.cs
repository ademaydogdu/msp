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
using Msp.Service.Service.Sale;
using Msp.Models.Models;
using Msp.App.Tool;
using Msp.Models.Models.Utilities;
using Msp.App.Report;

namespace Msp.App.Satis
{
    public partial class frmSatisBarkodIslem : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmSatisBarkodIslem()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        List<SaleBarcodCreateDTO> __dll_SaleBarcodCreate = new List<SaleBarcodCreateDTO>();
        MspTool mspTool = new MspTool();

        List<SelectIdValue> type = new List<SelectIdValue>()
        {
            new SelectIdValue(1 , "Yeni Kayıt"),
            new SelectIdValue(2 , "Silme - Liste Temizleme"),
            new SelectIdValue(3, "Satış"),
            new SelectIdValue(4, "Nakit - Satış"),
            new SelectIdValue(5, "Kredi Kartı - Satış"),

        };

        private void do_refresh()
        {
            try
            {
                __dll_SaleBarcodCreate = _repository.Run<SaleService, List<SaleBarcodCreateDTO>>(x => x.GetList_SaleBarcodCreateDTO());
                bs_saleBarcodeCreate.DataSource = __dll_SaleBarcodCreate;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        public void do_save()
        {
            try
            {

                var response = _repository.Run<SaleService, ActionResponse<List<SaleBarcodCreateDTO>>>(x => x.SaveSaleBarcodCreateDTO(__dll_SaleBarcodCreate));
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



        private void frmSatisBarkodIslem_Load(object sender, EventArgs e)
        {
            do_refresh();
            rp_Type.DataSource = type;
            rp_Type.DisplayMember = "Value";
            rp_Type.ValueMember = "Id";


        }

        private void frmSatisBarkodIslem_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void bbi_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (__dll_SaleBarcodCreate.Count > 0)
            {
                frmPrint frm = new frmPrint();
                frm.PrintSaleBarcodCreate(__dll_SaleBarcodCreate);
                frm.ShowDialog();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var Orow = (SaleBarcodCreateDTO)gridView1.GetFocusedRow();
            if (Orow != null)
            {
                string Barcode, Check12Digits;

                Random rnd = new Random();
                int sayi1 = (Convert.ToInt32(rnd.Next(10000, 999999999)));
                int sayi2 = (Convert.ToInt32(rnd.Next(10, 99)));
                string _barcode = Convert.ToString(sayi1 + "" + sayi2);

                if (_barcode.Length > 0)
                {
                    Check12Digits = _barcode.PadRight(12, '0');
                    Barcode = EAN13Class.EAN13(Check12Digits);
                    if (!String.Equals(EAN13Class.Barcode13Digits, "") || (EAN13Class.Barcode13Digits != ""))
                    {
                        Orow.Barcode = EAN13Class.Barcode13Digits.ToString();
                    }
                }
                gridControl1.RefreshDataSource();
            }
        }
    }
}