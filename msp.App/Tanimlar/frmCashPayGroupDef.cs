using DevExpress.XtraEditors;
using Msp.App.Tool;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using Msp.Service.Repository;
using Msp.Service.Service.Tanimlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.App.Tanimlar
{
    public partial class CashPayGroupDef : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public CashPayGroupDef()
        {
            InitializeComponent();
            _repository = new Repository();
     
        }



        List<CashPayGroupDefDTO> cashGroup = new List<CashPayGroupDefDTO>();
        MspTool MspTool = new MspTool();

        #region Do_Refresh

        public void do_refresh()
        {
            cashGroup = _repository.Run<DefinitionsService, List<CashPayGroupDefDTO>>(x => x.Get_List_CashPayGroup());
            bs_CashPayGroupDef.DataSource = cashGroup;
        }

        #endregion

        #region Record



        public void do_Save()
        {
            try
            {
                foreach (var item in cashGroup)
                {
                    if (cashGroup.Where(x => x.CashPayGroup == item.CashPayGroup).Count() > 1)
                    {
                        XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                        return;
                    }
                }
                var response = _repository.Run<DefinitionsService, ActionResponse<List<CashPayGroupDefDTO>>>(x => x.SaveCashPayGroupDefDTO(cashGroup));
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

        private void CashPayGroupDef_Load(object sender, EventArgs e)
        {
            do_refresh();
            MspTool.Get_Layout(this);
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            do_Save();
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void CashPayGroupDef_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CashPayGroupDefDTO oRow = (CashPayGroupDefDTO)gcv_CashPayGroupDef.GetFocusedRow();
            if (oRow != null)
            {
                if (MspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    if (oRow.RecId != 0)
                    {
                        var result = _repository.Run<DefinitionsService, ActionResponse<ProductGroupDTO>>(x => x.DeleteProductGroup(oRow.RecId));
                        do_refresh();
                    }
                    else
                    {
                        cashGroup.Remove(oRow);
                        gc_CashPayGroup.RefreshDataSource();
                    }


                }
            }
        }
    }
}