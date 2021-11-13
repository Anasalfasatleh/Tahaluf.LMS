using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tahaluf.LMS.Core.DTO;
using Tahaluf.LMS.Core.Repository;
using Tahaluf.LMS.Core.Services;

namespace Tahaluf.LMS.Infra.Services
{
    public class JWTService : IJWTService
    {
        private readonly IJWTRepository _jWTRepository;

        public JWTService(IJWTRepository jWTRepository)
        {
            this._jWTRepository = jWTRepository;
        }

        public string Auth(RequestLoginDTO loginDTO)
        {
            var result = _jWTRepository.Authentication(loginDTO);

            if (result == null)
            {
                return null;
            }
            else
            {
                //1- token handler : generate token
                var tokenHandler = new JwtSecurityTokenHandler();


                //2- token key : to encode data to token (secure value)
                var tokenKey = Encoding.ASCII.GetBytes("[Hello my Name is Anas Ahmad Alfasatleh]");


                //3- token descriptor :( userName , roleNoleName) + expire == session timeout + sign credential == Hmacsha256signtre (method) 
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    //userName, roleName
                    Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim(ClaimTypes.Name, result.UserName),
                        new Claim(ClaimTypes.Role, result.RoleName)
                        }),

                    //expire == session timeout
                    Expires = DateTime.UtcNow.AddHours(1),

                    //SigningCredential ==(to assign which encoding method to use) "Hmacsha256signutre"(method used to encode data)
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)

                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);

            }



        }



    }
}
