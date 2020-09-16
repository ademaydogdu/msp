using Msp.Entity.Entities;
using Msp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Settings
{
    public class SettingsService : BaseService
    {

        #region KullaniciTanimlari

        public List<UsersDTO> GetListUser()
        {
            using (var _db = new MspDbContext())
            {
                return base.Map<List<Users>, List<UsersDTO>>(_db.users.ToList());
            }
        }



        #endregion



    }
}
