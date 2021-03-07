using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("Appointments")]
    public class Appointments
    {
        [Key]
        public int UniqueID { get; set; }
        public int? Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? QueryStartDate { get; set; }
        public DateTime? QueryEndDate { get; set; }
        public bool? AllDay { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Label { get; set; }
        public int? ResourceID { get; set; }
        public string ResourceIDs { get; set; }
        public string ReminderInfo { get; set; }
        public string RecurrenceInfo { get; set; }
        public string TimeZoneId { get; set; }
        public string CustomField1 { get; set; }
    }
}
