using Msp.Entity.Entities;
using Msp.Models.Models;
using Msp.Models.Models.App;
using Msp.Models.Models.Utilities;
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

        public ActionResponse<GridSettingsDTO> Save_GridControl(GridSettingsDTO gridSettings)
        {
            ActionResponse<GridSettingsDTO> response = new ActionResponse<GridSettingsDTO>()
            {
                Response = gridSettings,
                ResponseType = ResponseType.Ok
            };
            using (var _db = new MspDbContext())
            {
                try
                {
                    var grid = _db.GridSettings.Where(x => x.GridName == gridSettings.GridName && x.FormName == gridSettings.FormName && x.UserCode == gridSettings.UserCode).FirstOrDefault();
                    if (grid != null)
                    {
                        gridSettings.RecId = grid.RecId;
                        _db.Entry(grid).CurrentValues.SetValues(gridSettings);
                        _db.Entry(grid).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        _db.GridSettings.Add(base.Map<GridSettingsDTO, GridSettings>(gridSettings));
                        _db.SaveChanges();
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        public GridSettingsDTO Get_GridControl(GridSettingsDTO gridSettings)
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<GridSettings, GridSettingsDTO>(_db.GridSettings.FirstOrDefault(x => x.GridName == gridSettings.GridName && x.FormName == gridSettings.FormName && x.UserCode == gridSettings.UserCode));
            }
        }


    }
}
