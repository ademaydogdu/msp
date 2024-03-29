﻿using System;
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
using Msp.Service.Service.Settings;
using Msp.Models.Models.Utilities;
using Msp.App.Tool;
using Msp.Infrastructure;

namespace Msp.App.Settings
{
    public partial class FrmCompany : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public FrmCompany()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<CompanyDTO> _List_Company = new List<CompanyDTO>();
        MspTool mspTool = new MspTool();

        public void do_refresh()
        {

            _List_Company = _repository.Run<SettingsService, List<CompanyDTO>>(x => x.GetList_Company());
            bs_companyList.DataSource = _List_Company;
        }

        private void do_edit()
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Update, (int)DocumentType.Company, AppMain.CompanyRecId)) return;

            CompanyDTO oRow = (CompanyDTO)gcv_company.GetFocusedRow();
            if (oRow != null)
            {
                FrmCompanyEdit _Form = new FrmCompanyEdit();
                _Form._FormOpenType = Infrastructure.FormOpenType.Edit;
                _Form.Show(oRow.RecId);
            }
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            do_refresh();
            mspTool.Get_GridControl(this.Name, gc_company);

        }

        public bool get_Question(string _Question)
        {
            bool _Return = false;
            if (DevExpress.XtraEditors.XtraMessageBox.Show(_Question, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _Return = true;
            }
            return _Return;
        }

        #region Form_Button
        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_edit();
        }
        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Insert, (int)DocumentType.Company, AppMain.CompanyRecId)) return;

            FrmCompanyEdit _Form = new FrmCompanyEdit();
            _Form._FormOpenType = Infrastructure.FormOpenType.New;
            _Form.Show(0);
        }
        private void bbi_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }

        #endregion

        private void bbi_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!MspTool.PermissionControl(AppMain.User.username, SecRightType.Delete, (int)DocumentType.Company, AppMain.CompanyRecId)) return;

            CompanyDTO oRow = (CompanyDTO)gcv_company.GetFocusedRow();
            if (oRow != null)
            {
                if (get_Question("Kayıt Silinecektir. Onaylıyor musunuz?"))
                {
                    var result = _repository.Run<SettingsService, ActionResponse<CompanyDTO>>(x => x.DeleteCompany(oRow.RecId));
                    do_refresh();
                }
            }

        }

        private void FrmCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gc_company);

        }

        private void gcv_company_DoubleClick(object sender, EventArgs e)
        {
            do_edit();
        }
    }
}