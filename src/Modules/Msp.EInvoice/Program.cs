using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.EInvoice
{
    public static class Program
    {
        [STAThread]
        public static void Main(string server, string database, string username, string password, string LookAndFeel)
        {

            UserLookAndFeel defaultLF = UserLookAndFeel.Default;
            defaultLF.UseWindowsXPTheme = false;
            defaultLF.Style = LookAndFeelStyle.Skin;
            defaultLF.SkinName = LookAndFeel;


            string connectionString = "initial catalog=" + database
               + ";data source=" + server
               + ";user id=" + username
               + ";password=" + password
               + ";Packet Size=8000;Connect Timeout=120";

            MainForm form = new MainForm(connectionString);
            form.Show();

        }
    }
}
