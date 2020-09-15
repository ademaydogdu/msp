using Msp.Infrastructure.DbConectionModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.App.Tool
{
    public class MspTool
    {
        public static bool sqlKontrol(string server, string database, string username, string password)
        {
            bool donus = true;
            string connectionString = "initial catalog=" + database
                + ";data source=" + server
                + ";user id=" + username
                + ";password=" + password
                + ";Packet Size=8000";

            SqlConnection sConn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sConn;
            try
            {
                cmd.Connection.Open();
            }
            catch
            {
                donus = false;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return donus;
        }






    }
}
