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
using Msp.Models.Models.SecRights;
using Msp.Service.Service.Admin;
using Msp.App.Tool;
using Msp.Models.Models.Utilities;

namespace Msp.App.Settings
{
    public partial class frmOpenFormRights : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;

        public frmOpenFormRights()
        {
            InitializeComponent();
            _repository = new Repository();

        }
        MspTool mspTool = new MspTool();
        List<UsersDTO> __List_users = new List<UsersDTO>();
        List<OpenFormRightsDTO> openFormRights = new List<OpenFormRightsDTO>();
             
        private void frmOpenFormRights_Load(object sender, EventArgs e)
        {
            mspTool.Get_Layout(this);

            __List_users = _repository.Run<SettingsService, List<UsersDTO>>(x => x.GetListUser());
            bs_UserList.DataSource = __List_users;

            lc_Users.EditValue = AppMain.User.username;
            if (AppMain.User.AdminAuthority == true)
            {
                lbGroupKullanıcı.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lbGroupKullanıcı.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            do_refresh();
        }

        public void do_refresh()
        {
            openFormRights = _repository.Run<AuthorizationService, List<OpenFormRightsDTO>>(x => x.OpenFormRights(Convert.ToString(lc_Users.EditValue), AppMain.CompanyRecId));
            bs_OpenFormRight.DataSource = openFormRights;
        }

        public void do_Save()
        {
            if (mspTool.get_Question("Kaydedilecektir Onaylıyor musunuz ?"))
            {
                gcv_OpenForms.CloseEditor();
                try
                {
                    var response = _repository.Run<SettingsService, ActionResponse<List<OpenFormRightsDTO>>>(x => x.SaveOpenFormRights(openFormRights));
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

        private void frmOpenFormRights_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.do_Save_Layout(this);
        }

        private void lc_Users_EditValueChanged(object sender, EventArgs e)
        {
            do_refresh();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_Save();
        }
    }
}