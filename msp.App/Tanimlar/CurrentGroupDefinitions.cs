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
using Msp.Infrastructure;

namespace Msp.App.Tanimlar
{
    public partial class CurrentGroupDefinitions : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public CurrentGroupDefinitions()
        {
            InitializeComponent();
            _repository = new Repository();
        }


        List<CurrentGroupDefinitionsDTO> __CurrentGroupDefinitions = new List<CurrentGroupDefinitionsDTO>();
        MspTool oTool = new MspTool();

        #region Record

        public void do_refresh()
        {
            try
            {
                __CurrentGroupDefinitions = _repository.Run<DepotStockService, List<CurrentGroupDefinitionsDTO>>(x => x.Get_List_CurrentGroupDefinitions());
                bs_CurrentGroupDefinitions.DataSource = __CurrentGroupDefinitions;
            }
            catch (Exception ex)
            {

            }
        }

        private void do_save()
        {
            try
            {
                foreach (var item in __CurrentGroupDefinitions)
                {
                    if (__CurrentGroupDefinitions.Where(x => x.Remark == item.Remark).Count() > 1)
                    {
                        XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                        return;
                    }
                }
                var response = _repository.Run<DepotStockService, ActionResponse<List<CurrentGroupDefinitionsDTO>>>(x => x.Save__CurrentGroupDefinitions(__CurrentGroupDefinitions));
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
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Insert, (int)DocumentType.CurrentGroupDefinitions, AppMain.CompanyRecId))
            {
                return;
            }
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
                if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Delete, (int)DocumentType.CurrentGroupDefinitions, AppMain.CompanyRecId))
                {
                    return;
                }

                if (oTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DepotStockService, ActionResponse<CurrentGroupDefinitionsDTO>>(x => x.Delete__CurrentGroupDefinitions(oRow.RecId));
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