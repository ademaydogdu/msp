using DevExpress.XtraEditors;
using Msp.Models.SimleCurrentModels;
using Msp.Service.Repository;
using Msp.Service.Service.SimleCurrent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msp.SimleCurrent.Screen
{
    public partial class frmSimleCurrentDefinitionList : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmSimleCurrentDefinitionList()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        List<SimleCurrentDefinitionDTO> List_simleCurrent = new List<SimleCurrentDefinitionDTO>();

        #region Record

        public void do_refresh()
        {
            try
            {
                List_simleCurrent = _repository.Run<SimleCurrentService, List<SimleCurrentDefinitionDTO>>(x => x.GetList_SimleCurrentDefinition());
                bs_Current.DataSource = List_simleCurrent;
            }
            catch (Exception ex)
            {

            }
        }

        #endregion


        private void frmSimleCurrentDefinitionList_Load(object sender, EventArgs e)
        {

        }

        private void bbi_closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSimleCurrentDefinition frm = new frmSimleCurrentDefinition();
            frm._FormOpenType = Infrastructure.FormOpenType.New;
            frm.ShowDialog();
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = (SimleCurrentDefinitionDTO)gcv_Current.GetFocusedRow();
            if (oRow != null)
            {
                frmSimleCurrentDefinition frm = new frmSimleCurrentDefinition();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.RecId = oRow.RecId;
                frm.ShowDialog();
            }
        }

        private void bbi_Deleted_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}