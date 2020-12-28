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
using Msp.Infrastructure;
using Msp.App.Tool;
using Msp.Models.Models.Invoice;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Invoice;

namespace Msp.App.CariIslemler
{
    public partial class FindIrsaliyeList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public FindIrsaliyeList()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public InvoiceType invoice;

        MspTool MspTool = new MspTool();
        List<InvoiceOwnerDTO> invoiceList = new List<InvoiceOwnerDTO>();

        List<SelectIdValue> IceType = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Alım Faturası"),
            new SelectIdValue(2, "Satış Faturasi"),
            new SelectIdValue(4, "Alım İrsaliyesi"),
            new SelectIdValue(5, "Satış İrsaliyesi"),
        };

        public void do_refresh()
        {
            try
            {
                invoiceList = _repository.Run<InvoiceService, List<InvoiceOwnerDTO>>(x => x.GetList_FindIrsaliye((int)invoice));
                bs_Invoice.DataSource = invoiceList;
            }
            catch (Exception)
            {
            }
        }

        private void FindIrsaliyeList_Load(object sender, EventArgs e)
        {
            MspTool.Get_Layout(this);
            do_refresh();
        }

        private void FindIrsaliyeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void FindIrsaliyeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_select_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (InvoiceOwnerDTO)gcv_FindIrsaliye.GetFocusedRow();
            if (oRow != null)
            {
                try
                {
                    Form _Form = MspTool.get_OpenForm("InvoiceEdit");
                    if (_Form != null)
                    {
                        ((InvoiceEdit)_Form).do_IrsaliyeSec(oRow.RecId, oRow.IrsaliyeNo);
                    }
                    _Form = null;

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Close();
                }

            }
        }
    }
}