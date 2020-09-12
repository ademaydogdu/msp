using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Utilities
{
    public class ActionResponse<T> where T : class
    {
        public ResponseType ResponseType { get; set; }

        public string Message { get; set; }
        public T Response { get; set; }
    }
    public enum ResponseType
    {
        Ok = 1,
        Warning = 2,
        Error = 3
    }
}
