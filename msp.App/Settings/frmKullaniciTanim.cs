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
using Msp.App.Tool;
using Msp.Infrastructure;

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

        MspTool mspTool = new MspTool();
        List<UsersDTO> __List_users = new List<UsersDTO>();

        public void do_refresh()
        {
            __List_users = _repository.Run<SettingsService, List<UsersDTO>>(x => x.GetListUser());
            bs_UserList.DataSource = __List_users;
        }

        private void frmKullaniciTanim_Load(object sender, EventArgs e)
        {

            do_refresh();
            mspTool.Get_GridControl(this.Name, gridControl1);
        }

        private void frmKullaniciTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            mspTool.Save_GridControl(this.Name, gridControl1);
        }

        private void bbi_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKullaniciTanimEdit frm = new frmKullaniciTanimEdit();
            frm._FormOpenType = Infrastructure.FormOpenType.New;
            frm.Show("");
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UsersDTO oRow = (UsersDTO)gridView1.GetFocusedRow();
            if (oRow != null)
            {
                if (oRow.username == "Admin")
                {
                    if (AppMain.User.username != "Admin")
                    {
                        return;
                    }
                }
                frmKullaniciTanimEdit frm = new frmKullaniciTanimEdit();
                frm._FormOpenType = Infrastructure.FormOpenType.Edit;
                frm.Show(oRow.username);
            }
        }

        private void bbi_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_View_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbi_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_refresh();
        }
    }
}