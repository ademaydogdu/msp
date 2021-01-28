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

        private void frmSatisBarkodIslem_Load(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void frmSatisBarkodIslem_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}