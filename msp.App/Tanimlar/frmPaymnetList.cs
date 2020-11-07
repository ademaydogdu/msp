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

namespace Msp.App.Tanimlar
{
    public partial class frmPaymnetList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmPaymnetList()
        {
            InitializeComponent();
            _repository = new Repository();
        }


        List<PaymentTypeDTO> __paymentTypes = new List<PaymentTypeDTO>();
        MspTool oTool = new MspTool();

        #region Record

        public void do_refresh()
        {
            try
            {
                __paymentTypes = _repository.Run<DepotStockService, List<PaymentTypeDTO>>(x => x.Get_List_Payment());
                bs_PaymentType.DataSource = __paymentTypes;
            }
            catch (Exception ex)
            {

            }
        }

        private void do_save()
        {
            try
            {
                foreach (var item in __paymentTypes)
                {
                    if (__paymentTypes.Where(x => x.Remark == item.Remark).Count() > 1)
                    {
                        XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                        return;
                    }
                }
                var response = _repository.Run<DepotStockService, ActionResponse<List<PaymentTypeDTO>>>(x => x.SavePayment(__paymentTypes));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    this.Close();
                }


            }
            catch (Exception ex)
            {

            }



        }


        #endregion


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmPaymnetList_Load(object sender, EventArgs e)
        {
            do_refresh();
            oTool.Get_GridControl(this.Name, gridControl1);
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oTool.get_Question("Kaydedilecektir Onaylıyor musunuz ?"))
            {
                gridView1.CloseEditor();
                do_save();
            }
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PaymentTypeDTO oRow = (PaymentTypeDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                if (oTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DepotStockService, ActionResponse<PaymentTypeDTO>>(x => x.DeletePayment(oRow.RecId));
                    do_refresh();
                }
            }
        }

        private void frmPaymnetList_FormClosing(object sender, FormClosingEventArgs e)
        {
            oTool.Save_GridControl(this.Name, gridControl1);
        }
    }
}