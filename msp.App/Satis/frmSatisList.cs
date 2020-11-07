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
using Msp.Models.Models.Sale;
using Msp.Service.Service.Sale;
using Msp.App.Tool;

namespace Msp.App.Satis
{
    public partial class frmSatisList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmSatisList()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        MspTool mspTool = new MspTool();
        List<SaleOwnerDTO> __dll_SaleOwner = new List<SaleOwnerDTO>();


        #region Record
        private void do_refresh(DateTime date)
        {
            try
            {
                __dll_SaleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_Date(date));
                bs_SaleOwner.DataSource = __dll_SaleOwner;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }


        }

        #endregion


        private void frmSatisList_Load(object sender, EventArgs e)
        {
            dt_Date.EditValue = DateTime.Today;
            do_refresh(dt_Date.DateTime);

            mspTool.Get_GridControl(this.Name, gc_SiparisList);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            do_refresh(dt_Date.DateTime);
        }

        private void frmSatisList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gc_SiparisList);
        }
    }
}