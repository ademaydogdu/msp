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
using Msp.App.Tool;
using System.IO.Ports;
using Msp.Models.Models;
using Msp.Infrastructure;
using Msp.Service.Repository;
using Msp.Service.Service.Settings;
using Msp.Service.Service.DepotStock;

namespace Msp.App.Satis
{
    public partial class frmPriceInquiry : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        ParametersDTO _parameters;
        public frmPriceInquiry()
        {
            InitializeComponent();
            _repository = new Repository();
            _parameters = new ParametersDTO();
            SetForm();

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
        }
        MspTool mspTool = new MspTool();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<UnitsDTO> _list_UnitsDTO = new List<UnitsDTO>();
        public List<KDVTaxDto> KdvOrani = new List<KDVTaxDto>
        {
            new KDVTaxDto(1, "%0", 0.00, 0),
            new KDVTaxDto(2, "%1", 0.01, 1),
            new KDVTaxDto(3, "%8", 0.08, 8),
            new KDVTaxDto(4, "%18", 0.18, 18),
        };

        private void SetForm()
        {
            _parameters = _repository.Run<SettingsService, ParametersDTO>(x => x.Get_Parameters());
        }

        private string BarCode = "";

        private void frmPriceInquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
            mspTool.Save_GridControl(this.Name, gc_PriceInQuery);
        }

        private void frmPriceInquiry_Load(object sender, EventArgs e)
        {
            mspTool.Get_GridControl(this.Name, gc_PriceInQuery);

            _list_UnitsDTO = _repository.Run<DepotStockService, List<UnitsDTO>>(x => x.GetListUnit());

            rp_KdvOran.DataSource = KdvOrani;
            rp_KdvOran.DisplayMember = "Value";
            rp_KdvOran.ValueMember = "Id";
            bs_Unit.DataSource = _list_UnitsDTO;
            try
            {
                if (!(serialPort1.IsOpen))
                    serialPort1.Open();
              
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Okutma Cihazına Erişilemiyor : " + ex.Message, "Error!");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            BarCode = "";
            BarCode = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            do_ProductBarcode(BarCode);
        }

        private void do_ProductBarcode(string __barcode)
        {
            if (__barcode.Length > 0)
            {
                var product = AppMain.Products.Where(x => x.PBarcode == __barcode.Trim()).FirstOrDefault();
                if (product != null)
                {
                    _productlist.Add(product);
                    bs_products.DataSource = _productlist;
                    gc_PriceInQuery.RefreshDataSource();
                }
            }

        }

    }
}