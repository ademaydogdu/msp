using Msp.Infrastructure.DbConectionModel;
using Msp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure
{
    public class AppMain
    {
        public static ConnectionDTO SqlConnection { get; set; }
        public static UsersDTO User { get; set; }
        public static Version MspVersion { get; set; }
        public static string LcConnectionString { get; set; }
        public static bool NetworkConnected = true;



    }
}
