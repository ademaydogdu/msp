using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models.Daily
{
    public class DailyRequest
    {
        public List<DailyTransDTO> dailyTrans { get; set; }
        public DailyOwnerDTO dailyOwner { get; set; }
    }
}
