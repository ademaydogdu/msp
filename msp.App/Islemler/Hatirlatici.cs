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
using Msp.Models.Models.Scheduler;
using Msp.Service.Repository;
using Msp.Service.Service.Scheduler;
using Msp.Models.Models.Utilities;

namespace Msp.App.Islemler
{
    public partial class Hatirlatici : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        public Hatirlatici()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        List<AppointmentsDTO> __Appointments = new List<AppointmentsDTO>();
        List<ResourcesDTO> __Resources = new List<ResourcesDTO>();

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {

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

            __Appointments =  _repository.Run<SchedulerService, List<AppointmentsDTO>>(x => x.GetListAppointments());
            bs_Appointments.DataSource = __Appointments;

            __Resources = _repository.Run<SchedulerService, List<ResourcesDTO>>(x => x.GetListResources());
            bs_Resources.DataSource = __Resources;

        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            var response = _repository.Run<SchedulerService, ActionResponse<List<AppointmentsDTO>>>(x => x.SaveAppointments(__Appointments));
            if (response.ResponseType != ResponseType.Ok)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(response.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}