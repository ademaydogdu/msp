using DevExpress.XtraEditors;
using Msp.Infrastructure;
using Msp.Models.Models.Utilities;
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
    public partial class frmSimleCurrentDefinition : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmSimleCurrentDefinition()
        {
            InitializeComponent();
            _repository = new Repository();
        }
        public FormOpenType _FormOpenType;
        SimleCurrentDefinitionDTO __simleCurrent = new SimleCurrentDefinitionDTO();
        public int RecId;
        #region Record

        public bool do_Validation()
        {
            bool _return = false;

            return _return;
        }
        private void do_save()
        {
            try
            {
                if (do_Validation()) return;

                var response = _repository.Run<SimleCurrentService, ActionResponse<SimleCurrentDefinitionDTO>>(x => x.Save_SimleCurrentDefinition(__simleCurrent));
                if (response.ResponseType != ResponseType.Ok)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == "frmSimleCurrentDefinitionList")
                        {
                            ((frmSimleCurrentDefinitionList)item).do_refresh();
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion



        private void frmSimleCurrentDefinition_Load(object sender, EventArgs e)
        {
            if (_FormOpenType == FormOpenType.New)
            {
                __simleCurrent = new SimleCurrentDefinitionDTO();

            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __simleCurrent = _repository.Run<SimleCurrentService, SimleCurrentDefinitionDTO>(x => x.Get_SimleCurrentDefinition(RecId));
            }
            bs_SimpleCurrent.DataSource = __simleCurrent;
        }

        private void bbi_Closed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}