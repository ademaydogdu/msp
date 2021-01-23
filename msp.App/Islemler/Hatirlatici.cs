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

namespace Msp.App.Islemler
{
    public partial class Hatirlatici : DevExpress.XtraEditors.XtraForm
    {
        public Hatirlatici()
        {
            InitializeComponent();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            Msp.App.Islemler.OutlookAppointmentForm form = new Msp.App.Islemler.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }
    }
}