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
using Msp.Infrastructure;
using Msp.Models.Models;
using Msp.Service.Repository;
using Msp.Service.Service.Settings;
using Msp.Models.Models.Utilities;

namespace Msp.App.Settings
{
    public partial class FrmCompanyEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public FrmCompanyEdit()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public FormOpenType _FormOpenType;

        private CompanyDTO __company = new CompanyDTO();

        public void Show(int RecId)
        {

            if (_FormOpenType == FormOpenType.New)
            {
                __company = new CompanyDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __company = _repository.Run<SettingsService, CompanyDTO>(x => x.Get_Company(RecId));
            }

            bs_CompanyEdit.DataSource = __company;
            this.ShowDialog();
        }

        #region Record

        private void do_save()
        {
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<SettingsService, ActionResponse<CompanyDTO>>(x => x.Save_Company(__company));
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
                    XtraMessageBox.Show(ex.Message);
                }
            }
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

        #endregion



        private void bbi_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }
    }
}