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
using Msp.Entity.Entities;

namespace Msp.App.Islemler
{
    public partial class Hatirlatici : DevExpress.XtraEditors.XtraForm
    {
        public Hatirlatici()
        {
            InitializeComponent();
        }

        List<Appointments> __Appointments = new List<Appointments>();
        List<Resources> __Resources = new List<Resources>();

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



        public static DateTime FirstDayOfWeek(DateTime date)
        {
            DayOfWeek fdow = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            int offset = fdow - date.DayOfWeek;
            DateTime fdowDate = date.AddDays(offset + 1);
            return fdowDate;
        }

        public static DateTime LastDayOfWeek(DateTime date)
        {
            DateTime ldowDate = FirstDayOfWeek(date).AddDays(6);
            return ldowDate;
        }

        private void Hatirlatici_Load(object sender, EventArgs e)
        {
            schedulerControl1.LimitInterval.Start = FirstDayOfWeek(DateTime.Now);
            schedulerControl1.LimitInterval.End = LastDayOfWeek(DateTime.Now);




        }
    }
}