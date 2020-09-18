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
using Msp.Service.Service.Settings;
using Msp.Models.Models.Utilities;

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

        public void do_refresh()
        {

            _List_Company = _repository.Run<SettingsService, List<CompanyDTO>>(x => x.GetList_Company());
            bs_companyList.DataSource = _List_Company;
        }


        private void FrmCompany_Load(object sender, EventArgs e)
        {
            do_refresh();
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
            CompanyDTO oRow = (CompanyDTO)gcv_company.GetFocusedRow();
            if (oRow != null)
            {
                FrmCompanyEdit _Form = new FrmCompanyEdit();
                _Form._FormOpenType = Infrastructure.FormOpenType.Edit;
                _Form.Show(oRow.RecId);
            }
        }
        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
    }
}