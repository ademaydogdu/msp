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
using Msp.App.Tool;
using Msp.Models.Models;
using Msp.Infrastructure;
using Msp.Service.Service.Tanimlar;
using Msp.Models.Models.Utilities;

namespace Msp.App.Tanimlar
{
    public partial class frmCaseDefinition : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmCaseDefinition()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        MspTool mspTool = new MspTool();
        List<CaseDefinitionDTO> __List_CaseDef = new List<CaseDefinitionDTO>();


        #region Record

        public void do_refresh()
        {
            try
            {
                __List_CaseDef = _repository.Run<DefinitionsService, List<CaseDefinitionDTO>>(x => x.Get_List_CaseDef(AppMain.CompanyRecId));
                bs_CaseDef.DataSource = __List_CaseDef;
            }
            catch (Exception ex)
            {
            }
        }

        private void do_Save()
        {
            if (mspTool.get_Question("Kaydedilecektir Onaylıyor musunuz ?"))
            {
                gcv_CaseDef.CloseEditor();
                try
                {
                    foreach (var item in __List_CaseDef)
                    {
                        if (__List_CaseDef.Where(x => x.CaseName == item.CaseName).Count() > 1)
                        {
                            XtraMessageBox.Show("Mükerrer Kayıt var. Lütfen Kontrol Ediniz.");
                            return;
                        }
                        item.CompanyRecId = AppMain.CompanyRecId;
                    }
                    var response = _repository.Run<DefinitionsService, ActionResponse<List<CaseDefinitionDTO>>>(x => x.SaveCaseDefinition(__List_CaseDef));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (Exception)
                {

                }
            }
        }


        #endregion


        private void frmCaseDefinition_Load(object sender, EventArgs e)
        {
            mspTool.Get_Layout(this);
            do_refresh();
        }

        private void frmCaseDefinition_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Save();
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CaseDefinitionDTO oRow = (CaseDefinitionDTO)gcv_CaseDef.GetFocusedRow();
            if (oRow != null)
            {
                if (mspTool.get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<DefinitionsService, ActionResponse<CaseDefinitionDTO>>(x => x.DeleteCaseDefinition(oRow.RecId));
                    do_refresh();
                }
            }
        }

        private void frmCaseDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}