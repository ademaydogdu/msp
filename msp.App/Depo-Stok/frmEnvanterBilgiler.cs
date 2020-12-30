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
using Msp.Service.Repository;
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Service.Service.App;
using Msp.Service.Service.Depot;

namespace Msp.App.Depo_Stok
{
    public partial class frmEnvanterBilgiler : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmEnvanterBilgiler()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool MspTool = new MspTool();
        List<ProductDTO> _productlist = new List<ProductDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();
        List<DepotDTO> _depotList = new List<DepotDTO>();

        private void frmEnvanterBilgiler_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);
            _productlist = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_Product.DataSource = _productlist;

            _company = _repository.Run<StartUp, List<CompanyDTO>>(x => x.GetList_Company());
            bs_company.DataSource = _company;

            _depotList = _repository.Run<DepotService, List<DepotDTO>>(x => x.GetListDepot());
            bs_Depot.DataSource = _depotList;



        }

        private void frmEnvanterBilgiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);

        }

        private void frmEnvanterBilgiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bbi_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}