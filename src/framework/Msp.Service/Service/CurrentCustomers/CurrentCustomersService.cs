using Msp.Entity.Entities;
using Msp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.CurrentCustomers
{
  public  class CurrentCustomersService : BaseService
    {
        public List<CCustomersDTO> GetCurrentCustomers() 
        
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<CCustomers>, List<CCustomersDTO>>(_db.CurrentCustomers.ToList());
            }
        }
    
    public CCustomersDTO GetCurrentCustomers(int id)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<CCustomers, CCustomersDTO>(_db.CurrentCustomers.FirstOrDefault(x => x.CCID == id));

            }
        }
    }
}
