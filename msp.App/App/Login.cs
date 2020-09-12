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
using Msp.Infrastructure;
using Msp.Infrastructure.DbConectionModel;
using Msp.Service.Service.Admin;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;

namespace Msp.App.App
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public Login()
        {
            InitializeComponent();
            _repository = new Repository();
        }



        #region Record

        private bool do_IsNotValid()
        {
            bool _return = false;
            if (txt_userCode.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Lütfen Kullanıcı Kodu Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            if (txt_Password.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Lütfen Parolanızı Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            return _return;
        }

        private void do_login()
        {
            if (do_IsNotValid()) return;

            AppMain.User = new Models.Models.UsersDTO();
            AppMain.User.password = txt_Password.Text;
            AppMain.User.username = txt_userCode.EditValue.ToString();

            ConnectionDTO config = new ConnectionDTO
            {
                Database = "msp", //Global.SqlConnection.Database,
                Server = "R00T\\SQLEXPRESS", //Global.SqlConnection.Server,
                Password = "123456", //Global.SqlConnection.Password,
                UserId = "ss" //Global.SqlConnection.UserId
            };

            UserAuthDto model = new UserAuthDto
            {
                Config = config,
                User = AppMain.User
            };

            var loginResponse = _repository.Run<AuthorizationService, ActionResponse<UsersDTO>>(x => x.LoginControl(model));
            if (loginResponse.ResponseType != ResponseType.Ok)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(loginResponse.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Password.Focus();
                return;
            }
            AppMain.User = loginResponse.Response;


            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm.Name.Trim() == "MainFrm")
                {
                    oForm.Text += "-" + this.lc_Company.Text.Trim() + "-" + AppMain.User.username;
                }
            }
            this.Close();

        }




        #endregion

        private void btn_login_Click(object sender, EventArgs e)
        {
            do_login();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}