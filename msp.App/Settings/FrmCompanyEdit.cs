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
using Msp.App.Tool;
using System.IO;

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

        MspTool tool = new MspTool();
        public FormOpenType _FormOpenType;
        private CompanyDTO __company = new CompanyDTO();
        byte[] imgbyte;

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
                    if (imgbyte != null)
                    {
                        __company.Logo = imgbyte;
                    }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image to Upload.";
                dlg.Filter = "Image File (*.jpg;*.bmp;*.gif,*.png)|*.jpg;*.bmp;*.gif;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                    try
                    {
                        String imageName = dlg.FileName;
                        Bitmap bmp = new Bitmap(imageName);
                        pcLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                        pcLogo.Image = (Image)bmp;
                        FileStream fstream = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                        imgbyte = new byte[fstream.Length];
                        fstream.Read(imgbyte, 0, Convert.ToInt32(fstream.Length));
                        fstream.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pcLogo.Image = null;
            __company.Logo = null;
        }
    }
}