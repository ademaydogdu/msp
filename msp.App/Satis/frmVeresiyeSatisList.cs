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
using Msp.Models.Models.Utilities;

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

        private void do_refresh()
        {
            __dll_SaleOwner = _repository.Run<SaleService, List<SaleOwnerDTO>>(x => x.GetList_VeresiyeSale());
            bs_SaleOwner.DataSource = __dll_SaleOwner;
        }

        private void frmVeresiyeSatisList_Load(object sender, EventArgs e)
        {

            do_refresh();

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
            var oRow = (SaleOwnerDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                oRow.Veresiye = false;
                oRow.VeresiyeClosedDate = DateTime.Now;
                var response = _repository.Run<SaleService, ActionResponse<SaleOwnerDTO>>(x => x.Update_Veresiye(oRow));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    do_refresh();
                }
            }
        }
    }
}