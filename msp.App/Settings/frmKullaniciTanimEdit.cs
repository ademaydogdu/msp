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
        List<SecRightsDTO> SecRights = new List<SecRightsDTO>();
        List<SelectIdValue> tblForm = new List<SelectIdValue>()
        {
            new SelectIdValue(1, "Ürün Kartı"),
            new SelectIdValue(2, "Satış"),
            new SelectIdValue(3, "Ödeme Tipi Tanımları"),
            new SelectIdValue(4, "Cari Grup Tanımları"),
            new SelectIdValue(5, "Fatura"),
            new SelectIdValue(6, "Sipariş"),
            new SelectIdValue(7, "Cari Kartları"),
            new SelectIdValue(8, "Depo Tanımları"),
            new SelectIdValue(9, "Banka"),
            new SelectIdValue(10, "Kasa Hareketi"),
            new SelectIdValue(11, "Müşteri Listesi"),
            new SelectIdValue(12, "İşyeri"),
        };

        public void Show(string _UserCode)
        {
            if (_FormOpenType == FormOpenType.New)
            {
                _user = new UsersDTO();
                xtrFormYetki.PageEnabled = false;
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                _user = _repository.Run<Service.Service.App.StartUp, UsersDTO>(r => r.GetUser(_UserCode));
                _user.password = txt_Parola.Text = SecurityExtension.Sifre_Coz(_user.password);
                xtrFormYetki.PageEnabled = true;

            }
            bs_usersEdit.DataSource = _user;
            this.Show();
        }

        private bool do_Validation()
        {
            bool _return = false;
            if (_user.password == null || Convert.ToString(txt_Parola.EditValue) == "")
            {
                XtraMessageBox.Show("Parola Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (_user.username == null || Convert.ToString(txt_KullanıcıKodu.EditValue) == "")
            {
                XtraMessageBox.Show("Kullanıcı Kodu Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            return _return;
        }

        private void do_save()
        {
            bs_usersEdit.EndEdit();
            if (do_Validation()) return;

            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    if (SecRights.Count == 0)
                    {
                        foreach (DocumentType item in (DocumentType[])Enum.GetValues(typeof(DocumentType)))
                        {
                            var secRighdt = AppMain.secRights.Where(x => x.UserCode == AppMain.User.username && x.DocumentType == (int)item).FirstOrDefault();
                            if (secRighdt == null)
                            {
                                SecRights.Add(new SecRightsDTO
                                {
                                    UserCode = _user.username,
                                    SecCode = _user.username,
                                    DocumentType = (int)item,
                                    SecDelete = 1,
                                    SecInsert = 1,
                                    SecPreview = 1,
                                    SecUpdate = 1,
                                    CompanyCode = AppMain.Company,
                                    CompanyRecId = AppMain.CompanyRecId
                                });
                            }
                        }                   
                    }
                    var secRight = _repository.Run<SettingsService, ActionResponse<List<SecRightsDTO>>>(x => x.SaveSecRights(SecRights));
                    if (secRight.ResponseType != ResponseType.Ok)
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show(secRight.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

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
                    SecRights = _repository.Run<SettingsService, List<SecRightsDTO>>(x => x.GetList_SecRightUserCode(_user.username));
                    bs_SecRight.DataSource = SecRights;
                }

            }
        }
    }
}