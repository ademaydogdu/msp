using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.App
{
    public class StartUp : BaseService
    {
        public ProgramsControlsDTO CheckVersion()
        {
            ProgramsControlsDTO dataVersion = new ProgramsControlsDTO()
            {
                MspVersion = "1.0.0.0",
            };
            using (MspDbContext db = new MspDbContext())
            {
                var versionDto = db.Database.SqlQuery<ProgramsControlsDTO>("select * from ProgramsControl").FirstOrDefault();
                if (versionDto == null)
                {
                    db.ProgramsControl.Add(base.Map<ProgramsControlsDTO, ProgramsControl>(dataVersion));
                    db.SaveChanges();
                    versionDto.MspVersion = dataVersion.MspVersion;
                }
                dataVersion = versionDto;
            }

            return dataVersion;
        }


        public List<ApplicationServerDTO> Get_List_ApplicationServer()
        {
            using (MspDbContext _db = new MspDbContext())
            {
                return base.Map<List<ApplicationServer>, List<ApplicationServerDTO>>(_db.ApplicationServer.ToList());
            }
        }

        public List<CompanyDTO> GetList_Company()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Company>, List<CompanyDTO>>(_db.Company.ToList());
            }
        }


    }
}
