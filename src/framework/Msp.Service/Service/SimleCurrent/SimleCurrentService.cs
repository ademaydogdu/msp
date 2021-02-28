using Msp.Entity.Entities;
using Msp.Models.SimleCurrentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.SimleCurrent
{
    public class SimleCurrentService : BaseService
    {

        public List<SimleCurrentDefinitionDTO> GetList_SimleCurrentDefinition()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<SimleCurrentDefinition>, List<SimleCurrentDefinitionDTO>>(_db.SimleCurrentDefinition.ToList());
            }
        }


    }
}
