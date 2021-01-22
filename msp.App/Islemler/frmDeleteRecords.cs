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
using Msp.Infrastructure;
using Msp.Models.Models.Sale;
using Msp.Service.Service.Sale;
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;

namespace Msp.App.Islemler
{
    public partial class frmDeleteRecords : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmDeleteRecords()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool mspTool = new MspTool();
        public DeleteForm _formType;

        List<SaleOwnerDTO> _saleOwner = new List<SaleOwnerDTO>();
        List<ProductDTO> _prodcts = new List<ProductDTO>();

        private void frmDeleteRecords_Load(object sender, EventArgs e)
        {
            switch (_formType)
            {
                case DeleteForm.SatisDeleted:
                    _saleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.Get_List_SaleOwner_Deleted());
                    gc_DeletedRecord.DataSource = _saleOwner;
                    break;
                case DeleteForm.UrunKarti:
                    _prodcts = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct_Deleted());
                    gc_DeletedRecord.DataSource = _saleOwner;
                    break;
                default:
                    break;
            }
        }

        private void frmDeleteRecords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}