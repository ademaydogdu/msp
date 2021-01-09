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
using Msp.Models.Models.Sale;
using Msp.App.Tool;
using Msp.Service.Repository;
using Msp.Service.Service.Sale;

namespace Msp.App.Satis
{
    public partial class frmVeresiyeSatisList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmVeresiyeSatisList()
        {
            _repository = new Repository();
            InitializeComponent();
        }
        MspTool mspTool = new MspTool();
        List<SaleOwnerDTO> __dll_SaleOwner = new List<SaleOwnerDTO>();


        private void frmVeresiyeSatisList_Load(object sender, EventArgs e)
        {

            __dll_SaleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_VeresiyeSale());
            bs_SaleOwner.DataSource = __dll_SaleOwner;

            mspTool.Get_GridControl(this.Name, gc_SiparisList);

        }

        private void frmVeresiyeSatisList_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gc_SiparisList);

        }

        private void frmVeresiyeSatisList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("xls", gc_SiparisList);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mspTool.Export2AnyDocument("pdf", gc_SiparisList);
        }

        private void bbi_VeresiyeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}