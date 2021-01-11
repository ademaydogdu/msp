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
using DevExpress.XtraWizard;

namespace Msp.App.App
{
    public partial class Wizard : DevExpress.XtraEditors.XtraForm
    {
        public Wizard()
        {
            InitializeComponent();
        }

        #region DescRiption

        private bool SqlLocal;

        #endregion



        private void do_LisansDemo()
        {
            dt_RecordDate.EditValue = DateTime.Now;
            if (rpLisans.Checked)
            {

            }
            if (rpDeneme.Checked)
            {

            }

        }

        private void do_SqlConnect()
        {

        }
        private void do_FirstRecord()
        {
            if (true)
            {

            }
        }


        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == pageLisansDemo)
            {
                e.Page.AllowNext = false;
                if (!rpDeneme.Checked || !rpLisans.Checked)
                {
                    e.Page.AllowNext = false;
                }
                do_LisansDemo();

            }
            if (e.Page == pageSqlSettings)
            {

            }
            if (e.Page == pageRecordPage)
            {
                do_FirstRecord();
            }
        }

        private void Wizard_Load(object sender, EventArgs e)
        {

        }

        private void rpLisans_CheckedChanged(object sender, EventArgs e)
        {
            rpLisans.Visible = true;
            rpDeneme.Visible = false;
            gc_Lisans.Visible = true;
            gc_Denme.Visible = false;
        }

        private void rpDeneme_CheckedChanged(object sender, EventArgs e)
        {
            rpLisans.Visible = false;
            rpDeneme.Visible = true;
            gc_Lisans.Visible = false;
            gc_Denme.Visible = true;
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wizardLisansAnlasmasi)
            {
                if (!cb_LisansControl.Checked)
                    e.Page.AllowNext = false;
            }
            if (e.Page == pageSqlSettings)
            {
                if (!chcSunucu.Checked || !chLocalDB.Checked)
                    e.Page.AllowNext = false;
            }
            if (e.Page == pageLisansDemo)
            {
                //e.Page.AllowNext = false;
            }
        }


        private void cb_LisansControl_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_LisansControl.Checked)
            {
                wizardLisansAnlasmasi.AllowNext = true;
            }
            else
            {
                wizardLisansAnlasmasi.AllowNext = false;
            }
        }

        private void chLocalDB_CheckedChanged(object sender, EventArgs e)
        {
            if (chLocalDB.Checked)
            {
                chcSunucu.Checked = false;
                grpServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                pageSqlSettings.AllowNext = true;
                lytLocalString.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                pageSqlSettings.AllowNext = false;
                lytLocalString.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
        }

        private void chcSunucu_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSunucu.Checked)
            {
                chcSunucu.Checked = true;
                chLocalDB.Checked = false;
                grpServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lytLocalString.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
            else
            {
                grpServer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            }
            pageSqlSettings.AllowNext = false;

        }
    }
}