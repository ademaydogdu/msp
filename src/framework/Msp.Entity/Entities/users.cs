namespace Msp.Entity.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public class Users
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string note { get; set; }
        public DateTime? date { get; set; }
        public bool? Active { get; set; }
        public string HaspPassword { get; set; }
        public string Email { get; set; }
        public string DefaultTheme { get; set; }
        public string DefaultTheme2 { get; set; }
        public bool? AdminAuthority { get; set; }
        public bool? ReportPrint { get; set; } 
        public bool? ExportExcelPdf { get; set; } 
        public bool? DailyEndOperation { get; set; } 
        public bool? EnvanterEntry { get; set; } 
        public bool? VeresiyeDefterClosed { get; set; } 

    }
}
