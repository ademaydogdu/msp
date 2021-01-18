using Msp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure.DbConectionModel
{
    public class ConnectionDTO
    {
        public ConnectionDTO()
        {

            Server = "";
            Database = "";
            UserId = "";
            Password = "";
        }
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool localSql { get; set; } = false;

        public string Connection()
        {
            return $"initial catalog={Database};data source={Server} " + (localSql == false ? $";user id={UserId};password={Password}; Packet Size=8000;Connect Timeout=120" : "; Packet Size=8000;Connect Timeout=120");
        }
    }

    public class UserAuthDto
    {
        public ConnectionDTO Config { get; set; }
        public UsersDTO User { get; set; }
    }
}
