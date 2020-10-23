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
using Msp.Service.Service.Depot;
using Msp.Models.Models.Utilities;
using DevExpress.XtraBars;

namespace Msp.App.Depo_Stok
{
    public partial class frmDepoEdit : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository = new Repository();
        public frmDepoEdit()
        {
            InitializeComponent();
        }
        public FormOpenType _FormOpenType;

        private DepotDTO __depot = new DepotDTO();


        public void Show(int id)
        {
           

            if (_FormOpenType == FormOpenType.New)
            {
                __depot = new DepotDTO();
            }
            if (_FormOpenType == FormOpenType.Edit)
            {
                __depot = _repository.Run<DepotService, DepotDTO>(x => x.GetDepot(id));
            }



            bs_DepotEdit.DataSource = __depot;
            this.ShowDialog();
        }

        #region Record


        private bool do_Validation()
        {
            bool _return = false;
            if (Convert.ToString(DepotNameTE.EditValue) == "")
            {
                XtraMessageBox.Show("Depo Adı Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (Convert.ToString(DepotAuthPersonTE.EditValue) == "")
            {
                XtraMessageBox.Show("Yetkili Kişi Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (Convert.ToString(DepotTaxAdminsTE.EditValue) == "")
            {
                XtraMessageBox.Show("Vergi Dairesi Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            if (Convert.ToString(DepTaxNoTE.EditValue) == "")
            {
                XtraMessageBox.Show("Vergi Numarası Bilgisi Girilmesi Zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _return = true;
            }
            return _return;
        }


        private void do_save()
        {
            if (do_Validation()) return;
            if (get_Question("Kaydedilecektir Onaylıyor Musunuz?"))
            {
                try
                {
                    var response = _repository.Run<DepotService, ActionResponse<DepotDTO>>(x => x.SaveDepot(__depot));
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            do_save();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmDepoEdit_Load(object sender, EventArgs e)
        {

        }
    }
}