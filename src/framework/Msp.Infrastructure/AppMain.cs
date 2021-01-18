using Msp.Infrastructure.DbConectionModel;
using Msp.Models.Models;
using Msp.Models.Models.SecRights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure
{
    public class AppMain
    {
        public static Dictionary<string, string> Forms { get; set; }
        public static List<OpenFormRightsDTO> OpenFormRights { get; set; }
        public static List<SecRightsDTO> secRights { get; set; }
        public static ConnectionDTO SqlConnection { get; set; }
        public static UsersDTO User { get; set; }
        public static Version MspVersion { get; set; }
        public static string LcConnectionString { get; set; }
        public static bool NetworkConnected = true;
        public static string Company { get; set; }
        public static int CompanyRecId { get; set; }

        public static bool LocalConnect { get; set; }


        public static string MAcAdress { get; set; }
        public static string IpAdress { get; set; }
        public static string LocalIpAdress { get; set; }


    }
}
