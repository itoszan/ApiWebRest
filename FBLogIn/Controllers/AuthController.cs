using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FBLogIn.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FBLogIn.Controllers
{ [Route("API/auth")]
  [ApiController]
    public class AuthController:ControllerBase
    {
        [HttpPost,Route("login")]
        public IActionResult Login([FromBody]LoginModel user)
        {   
            if (user==null)
                return BadRequest("Invalido");

            if ((user.UserName == "Juan1234" && user.Password == "1234") || (user.UserName == "Pedro567" && user.Password == "567"))


            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("xxxx  yyyy  zzzzzz rrrrr"));
                var singingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken
                (
                    issuer: "https://localhost:44313",
                    audience: "https://localhost:44313",
                    claims:new List<Claim>(),
                    expires:DateTime.Now.AddMinutes(5),
                    signingCredentials:singingCredentials

                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok( new { Token = tokenString });
            }
            return Unauthorized();

        }
    }
}
