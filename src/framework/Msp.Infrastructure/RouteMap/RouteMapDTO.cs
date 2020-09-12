using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure.RouteMap
{
    public class RouteMapDTO
    {
        public string Name { get; set; }
        public string Route { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}
