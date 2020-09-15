using Msp.Entity.Entities;
using Msp.Infrastructure.DbConectionModel;
using Msp.Infrastructure.Extensions;
using Msp.Models.Models;
using Msp.Models.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Service.Admin
{
    public class AuthorizationService : BaseService
    {

        public ActionResponse<UsersDTO> LoginControl(UserAuthDto userAuth)
        {
            var userDto = userAuth.User;
            ActionResponse<UsersDTO> response = new ActionResponse<UsersDTO>() { Response = new UsersDTO(), ResponseType = ResponseType.Ok };
            using (var _db = new MspDbContext(userAuth.Config.Connection()))
            {
                try
                {
                    string query = "select * from Users where username = @username";
                    var _param = new SqlParameter[]
                    {
                        new SqlParameter{ParameterName = "username", Value = userDto.username }
                    };
                    UsersDTO users = _db.Database.SqlQuery<UsersDTO>(query, _param).FirstOrDefault();
                    //var users = _db.users.FirstOrDefault(x => x.username == userDto.username);
                    if (users != null)
                    {
                        if (!string.IsNullOrEmpty(users.HaspPassword))
                        {
                            if (userDto.password.ConvertStringToMD5() != users.HaspPassword)
                            {
                                response.ResponseType = ResponseType.Error;
                                response.Message = "Hatalı Şifre";
                            }
                        }
                        else
                        {
                            if (userDto.password != users.password)
                            {
                                response.ResponseType = ResponseType.Error;
                                response.Message = "Hatalı Şifre";
                            }
                        }
                    }
                    else
                    {
                        response.ResponseType = ResponseType.Error;
                        response.Message = "Kullanıcı Bulunamadı";
                    }
                    response.Response = users;
                }
                catch (Exception ex)
                {
                    response.ResponseType = ResponseType.Error;
                    response.Message = ex.Message;
                }
            }
            return response;
        }




    }
}
