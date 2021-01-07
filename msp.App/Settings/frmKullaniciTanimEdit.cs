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
using Msp.Infrastructure;
using Msp.Service.Service.Settings;
using Msp.Models.Models.Utilities;
using Msp.Infrastructure.Extensions;
using Msp.Models.Models.SecRights;

namespace Msp.App.Settings
{
    public partial class frmKullaniciTanimEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;

        public frmKullaniciTanimEdit()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        public FormOpenType _FormOpenType;
        private UsersDTO _user = new UsersDTO();

        List<SelectIdValue> tblForm = new List<SelectIdValue>() 
        {
            new SelectIdValue(1, "Ürün Kartı")
        };

        public void Show(string _UserCode)
        {
            if (_FormOpenType == FormOpenType.New)
            {
                _user = new UsersDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                 _user = _repository.Run<Service.Service.App.StartUp, UsersDTO>(r => r.GetUser(_UserCode));
                _user.password = txt_Parola.Text = SecurityExtension.Sifre_Coz(_user.password);
            }
            bs_usersEdit.DataSource = _user;
            this.Show();
        }

        private void do_save()
        {
            bs_usersEdit.EndEdit();
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {

                    _user.password = SecurityExtension.Sifrele(txt_Parola.Text);
                    _user.HaspPassword = SecurityExtension.ConvertStringToMD5(txt_Parola.Text);
                    var response = _repository.Run<SettingsService, ActionResponse<UsersDTO>>(x => x.Save_Users(_user));
                    if (response.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == "frmKullaniciTanim")
                            {
                                ((frmKullaniciTanim)item).do_refresh();
                            }
                        }
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

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void frmKullaniciTanimEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtrFormYetki)
            {
                repositoryItemLookUpEdit1.DataSource = tblForm;
                repositoryItemLookUpEdit1.ValueMember = "Id";
                repositoryItemLookUpEdit1.DisplayMember = "Value";

                if (_FormOpenType != FormOpenType.New)
                {
                    var secRight = _repository.Run<SettingsService, List<SecRightsDTO>>(x=>x.GetList_SecRightUserCode(_user.username));
                    bs_SecRight.DataSource = secRight;
                }

            }
        }
    }
}