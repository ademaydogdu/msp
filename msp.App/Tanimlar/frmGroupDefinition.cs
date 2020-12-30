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
    
    public partial class frmGroupDefinition : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmGroupDefinition()
        {
            InitializeComponent();
            _repository = new Repository();
        }


        List<ProductGroupDTO> productGroup = new List<ProductGroupDTO>();
        MspTool MspTool = new MspTool();


        #region Do_Refresh

        public void do_refresh()
        {
            productGroup = _repository.Run<DefinitionsService, List<ProductGroupDTO>>(x => x.Get_List_ProductGroup());
            bs_GroupDefinition.DataSource = productGroup;
        }

        #endregion

        #region Record



        public void do_Save()
        {
            try
            {
                foreach (var item in productGroup)
                {
                    if (productGroup.Where(x => x.Grouup == item.Grouup).Count() > 1)
                    {
                        XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                        return;
                    }
                }
                var response = _repository.Run<DefinitionsService, ActionResponse<List<ProductGroupDTO>>>(x => x.SaveProductGroup(productGroup));
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

        private void frmGroupDefinition_Load(object sender, EventArgs e)
        {
            do_refresh();
            MspTool.Get_Layout(this);
        }

        private void frmGroupDefinition_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);
        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Save();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductGroupDTO oRow = (ProductGroupDTO)gvc_Group.GetFocusedRow();
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
                        productGroup.Remove(oRow);
                        gc_Group.RefreshDataSource();
                    }


                }
            }
        }
    }
}