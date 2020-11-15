﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Msp.Infrastructure;
using Msp.App.Tool;
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Models.Models.Invoice;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Invoice;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.CurrentTransactions;

namespace Msp.App.CariIslemler
{
    public partial class InvoiceEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public InvoiceEdit()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
        }
        public InvoiceType invoice;
        public FormOpenType _FormOpenType;
        public int RecId;
        MspTool MspTool = new MspTool();
        InvoiceOwnerDTO __dll_InvoiceOwner = new InvoiceOwnerDTO();
        List<InvoiceTransDTO> __dll_List_InoviceTrans = new List<InvoiceTransDTO>();
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<CTransactionsDTO> _currentTransactionsList = new List<CTransactionsDTO>();


        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        #region Record

        public bool do_Validation()
        {
            bool _return = false;
            if (__dll_List_InoviceTrans.Count == 0)
            {
                MessageBox.Show("Boş Satır Kaydedilemez...");
                _return = true;
            }
 
            return _return;
        }

        public void do_save()
        {
            try
            {
                if (do_Validation()) return;
                if (MspTool.get_Question("Kaydedilecektir Onaylıyor musunuz?"))
                {
                    var req = new InvoiceSaveRequest()
                    {
                        InvoiceOwner = __dll_InvoiceOwner,
                        InvoiceTrans = __dll_List_InoviceTrans
                    };
                    var response = _repository.Run<InvoiceService, ActionResponse<InvoiceSaveRequest>>(x => x.Save_Inovice(req));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


        #endregion


        #region Form

        private void InvoiceEdit_Load(object sender, EventArgs e)
        {
            switch (invoice)
            {
                case InvoiceType.AlımFaturası:
                    this.Text = "Alım Faturası";
                    break;
                default:
                    break;
            }
            MspTool.Get_Layout(this);


            if (_FormOpenType == FormOpenType.New)
            {
                __dll_InvoiceOwner = new InvoiceOwnerDTO();
                __dll_List_InoviceTrans = new List<InvoiceTransDTO>();
                __dll_InvoiceOwner.InvoiceType = (int)invoice;
                __dll_InvoiceOwner.FicDate = DateTime.Now;
                __dll_InvoiceOwner.FichTime = DateTime.Now.TimeOfDay;
                __dll_InvoiceOwner.VadeTarih = DateTime.Now;
            }
            if (_FormOpenType == FormOpenType.Edit)
            {

            }
            if (_FormOpenType == FormOpenType.View)
            {

            }

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());
            bs_Unit.DataSource = _list_UnitsDTO;

            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_Product.DataSource = _productlist;

            _currentTransactionsList = _repository.Run<CurrentTransactionsService, List<CTransactionsDTO>>(x => x.GetListCurrentTransactions());
            bs_CariHesap.DataSource = _currentTransactionsList;

            rp_KDV.DataSource = KdvOrani;
            rp_KDV.ValueMember = "id";
            rp_KDV.DisplayMember = "value";

            bs_InvoiceOwner.DataSource = __dll_InvoiceOwner;
            bs_InvoiceTrans.DataSource = __dll_List_InoviceTrans;

        }

        private void InvoiceEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void InvoiceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }
        #endregion

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcv_invoiceTrans.CloseEditor();
            do_save();
        }
    }
}