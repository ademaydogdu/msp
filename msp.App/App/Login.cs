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
using Msp.Models.Models.App;
using System.IO;
using Msp.App.Tool;
using Msp.Service.Service.App;

namespace Msp.App.App
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public Login()
        {
            InitializeComponent();
            _repository = new Repository();

            Set_Form();
        }

        List<ApplicationServerDTO> applicationServers = new List<ApplicationServerDTO>();

        #region Record

        private void Set_Form()
        {


            #region CreateFile
            string root = @"C:\Msp";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string path = @"C:\Msp\ConnectString.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("data source=DG;initial catalog=msp;user id=sa;password=123D654!;");
                }
            }
            string[] conArry;
            using (StreamReader sr = File.OpenText(path))
            {
                string str = sr.ReadLine();
                conArry = str.Split(';');
            }
            List<string> conn = new List<string>();
            foreach (var item in conArry)
            {
                int position = item.IndexOf("=");
                if (position < 0)
                    continue;
                conn.Add(item.Substring(position + 1));
            }
            AppMain.SqlConnection = new ConnectionDTO
            {
                Database = conn[1], //Global.SqlConnection.Database,
                Server = conn[0], //"R00T\\SQLEXPRESS", //Global.SqlConnection.Server,
                Password = conn[3], //Global.SqlConnection.Password,
                UserId = conn[2] //Global.SqlConnection.UserId
            };
            #endregion

            if (MspTool.sqlKontrol(AppMain.SqlConnection.Server, AppMain.SqlConnection.Database, AppMain.SqlConnection.UserId, AppMain.SqlConnection.Password) == false)
            {
                XtraMessageBox.Show("Bağlantı hatası.Veritabanı ayarlarınızı kontrol ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDatabase();

        }

        public void LoadDatabase()
        {
            applicationServers = _repository.Run<StartUp, List<ApplicationServerDTO>>(x => x.Get_List_ApplicationServer());
            bs_ServerList.DataSource = applicationServers;


        }


        //public string GetUserDatabase(string userName)
        //{
        //    //OUZ: Login GetServerList
        //    applicationServer = SednaFBMain.GetServerList(userName);// SednaFBMain.KodAdmin.Service.GetServerList(userName);
        //    LoadDatabaseSettings();
        //    if (applicationServer.Count == 0)
        //    {
        //        this.sednaFBDatabase.Rows.Clear();
        //        //this.fBDataSet.CompanyRightUser.Clear();
        //        this.serverLookUpEdit.EditValue = -1;
        //        txtUserName.Text = string.Empty;
        //        return "Bağlantı bulunamadı";
        //    }

        //    if (baglimi)
        //    {
        //        InitializeCommand();
        //    }

        //    companyRightUserBindingSource.DataSource = Global.CompanyRightsOfUser;
        //    lstCompanyList.DisplayMember = "Company.Name";
        //    return "";

        //}



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

            AppMain.SqlConnection = new ConnectionDTO
            {
                Database = "msp", //Global.SqlConnection.Database,
                Server = "DG", //"R00T\\SQLEXPRESS", //Global.SqlConnection.Server,
                Password = "123D654!", //Global.SqlConnection.Password,
                UserId = "sa" //Global.SqlConnection.UserId
            };

            ConnectionDTO config = new ConnectionDTO
            {
                Database = "msp", //Global.SqlConnection.Database,
                Server =  "DG", //"R00T\\SQLEXPRESS", //Global.SqlConnection.Server,
                Password = "123D654!", //Global.SqlConnection.Password,
                UserId = "sa" //Global.SqlConnection.UserId
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