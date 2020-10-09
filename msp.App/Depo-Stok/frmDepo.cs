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
using Msp.Models.Models;
using Msp.Service.Service.DepotStock;
using Msp.Models.Models.Utilities;
using Msp.App.Tool;
using msp.App;

namespace Msp.App.Depo_Stok
{
    public partial class frmDepo : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmDepo()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<DepotDTO> _depotList = new List<DepotDTO>();

        public void do_refresh()
        {

            _depotList = _repository.Run<DepotStockService, List<ProductDTO>>(x => x.GetListProduct());
            bs_products.DataSource = _productlist;
        }

    }
}