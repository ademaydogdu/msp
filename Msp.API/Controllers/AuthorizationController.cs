using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Msp.Infrastructure;
using Msp.Infrastructure.DbConectionModel;
using Msp.Models.Models.Utilities;
using Msp.Service.Service.Admin;

namespace Msp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {

        private AuthorizationService _authorizationService;
        private readonly IConfiguration _config;

        public AuthorizationController(IConfiguration config)
        {
            _config = config;
            _authorizationService = new AuthorizationService();
        }

        [HttpPost]
        [ActionName("LoginModel")]
        public IActionResult LoginModel(UserAuthDto model)
        {
            var userLogin = _authorizationService.LoginControl(model);
            if (userLogin.ResponseType != ResponseType.Ok)
            {
                return Unauthorized();
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:Token").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.NameIdentifier, userLogin.Response.id.ToString()),
                        new Claim(ClaimTypes.Name, userLogin.Response.username),

                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            AppMain.SqlConnection = new ConnectionDTO
            {
                Server = model.Config.Server,
                Database = model.Config.Database,
                UserId = model.Config.UserId,
                Password = model.Config.Password
            };
            AppMain.User = userLogin.Response;
            return Ok(new
            {
                ResponseType = userLogin.ResponseType,
                Response = userLogin.Response,
                tokenString
            });
        }

        [HttpGet]
        [ActionName("OpenFormRights")]
        public IActionResult OpenFormRights(string userCode, int CompnayRecId)
        {
            return Ok(_authorizationService.OpenFormRights(userCode, CompnayRecId));
        }




    }
}