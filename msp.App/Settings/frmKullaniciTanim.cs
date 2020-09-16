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

namespace Msp.App.Settings
{
    public partial class frmKullaniciTanim : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public frmKullaniciTanim()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<UsersDTO> __List_users = new List<UsersDTO>();


        private void frmKullaniciTanim_Load(object sender, EventArgs e)
        {

            __List_users = _repository.Run<SettingsService, List<UsersDTO>>(x => x.GetListUser());
            bs_UserList.DataSource = __List_users;


        }





    }
}