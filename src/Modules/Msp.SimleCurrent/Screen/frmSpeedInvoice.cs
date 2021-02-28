using DevExpress.XtraEditors;
using Msp.Infrastructure;
using Msp.Models.Models.Utilities;
using Msp.Models.SimleCurrentModels;
using Msp.Service.Repository;
using Msp.Service.Service.SimleCurrent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.SimleCurrent.Screen
{
    public partial class frmSpeedInvoice : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmSpeedInvoice()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        SimpleInvoiceOwnerDTO __InvoiceOwner = new SimpleInvoiceOwnerDTO();
        List<SimleCurrentDefinitionDTO> List_simleCurrent = new List<SimleCurrentDefinitionDTO>();

        List<SelectIdValue> FaturaTuru = new List<SelectIdValue>
        {
            new SelectIdValue(1,"Alış Faturası"),
            new SelectIdValue(2, "Satış Faturası")
        };
        public FormOpenType _FormOpenType;



        #region Record

        private void do_refresh_Current()
        {
            List_simleCurrent = _repository.Run<SimleCurrentService, List<SimleCurrentDefinitionDTO>>(x => x.GetList_SimleCurrentDefinition());
            bs_Current.DataSource = List_simleCurrent;

        }
        public bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToInt32(txtTutar.EditValue) == 0)
            {
                XtraMessageBox.Show("Tutar Girişi yapınız", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            if ((string)lc_Doviz.EditValue == "")
            {
                XtraMessageBox.Show("Döviz Cinsi Seçiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }

            return _return;
        }

        private void do_save()
        {
            try
            {
                if (do_Validation()) return;

                decimal _tutar = (decimal)txtTutar.EditValue;
                if ((int)lc_FaaturaTuru.EditValue == 1)
                {
                    if (lc_Doviz.EditValue.ToString().Trim() == "TL")
                    {
                        __InvoiceOwner.Alacak = _tutar;
                        __InvoiceOwner.Borc = 0;
                    }
                    else
                    {
                        __InvoiceOwner.CurrencyAlacak = _tutar;
                        __InvoiceOwner.CurrencyBorc = 0;
                    }
                }
                else
                {
                    if (lc_Doviz.EditValue.ToString().Trim() == "TL")
                    {
                        __InvoiceOwner.Borc = _tutar;
                        __InvoiceOwner.Alacak = 0;
                    }
                    else
                    {
                        __InvoiceOwner.CurrencyBorc = _tutar;
                        __InvoiceOwner.CurrencyAlacak = 0;
                    }
                }




                var response = _repository.Run<SimleCurrentService, ActionResponse<SimpleInvoiceOwnerDTO>>(x => x.Save_SimpleInvoiceOwner_Easy(__InvoiceOwner));
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

            }
        }

        #endregion


        private void frmSpeedInvoice_Load(object sender, EventArgs e)
        {
            lc_FaaturaTuru.Properties.DataSource = FaturaTuru;
            lc_FaaturaTuru.Properties.DisplayMember = "Value";
            lc_FaaturaTuru.Properties.ValueMember = "Id";
            do_refresh_Current();
            if (_FormOpenType == FormOpenType.New)
            {
                __InvoiceOwner = new SimpleInvoiceOwnerDTO();
                __InvoiceOwner.IsDetail = false;
                __InvoiceOwner.InvoiceDate = DateTime.Today;
                dt_FisTarihi.DateTime = DateTime.Today;
                __InvoiceOwner.InvoiceType = 1;
            }
            if (_FormOpenType == FormOpenType.Edit)
            {

            }
            bs_InoviceOwner.DataSource = __InvoiceOwner;
        }

        private void btnClosed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void lc_CariKodu_EditValueChanged(object sender, EventArgs e)
        {
            if (lc_CariKodu.EditValue != null)
            {
                if (lc_CariKodu.EditValue.ToString().Length > 0)
                {
                    var current = List_simleCurrent.FirstOrDefault(x => x.RecId == (int)lc_CariKodu.EditValue);
                    if (current != null)
                    {
                        txtAdress.EditValue = current.Adress;
                        txtFax.EditValue = current.Fax;
                        txtUnvan.EditValue = current.CUnvan;
                        txtTel.EditValue = current.Phone;
                        txtVergiDairesi.EditValue = current.VergiDairesi;
                        txtVergiNo.EditValue = current.VergiNo;
                    }
                } 
            }
        }

        private void lc_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                try
                {
                    frmSimleCurrentDefinition frm = new frmSimleCurrentDefinition();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    do_refresh_Current();
                }
            }
        }
    }
}