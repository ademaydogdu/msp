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

namespace Msp.App.App
{
    public partial class Wizard : DevExpress.XtraEditors.XtraForm
    {
        public Wizard()
        {
            InitializeComponent();
        }


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
        }

        private void rpDeneme_CheckedChanged(object sender, EventArgs e)
        {
            rpLisans.Visible = false;
            rpDeneme.Visible = true;
        }
    }
}