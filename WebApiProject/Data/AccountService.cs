using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using System.Threading.Tasks;
using WebApiProject.BusinessModel;

namespace WebApiProject.Data
{
    public class AccountService : IAccountService
    {

        public async Task<ResponseModel> Login(LoginModel user)
        {
            ResponseModel resp = new ResponseModel();
            resp.Message = string.Empty;
            resp.Success = false;
            resp.Data = null;
             
            if (user is null)
            {
                resp.Message = "User not fuoud";
                return resp;
            }

            if (user.UserName == "junaid" && user.Password == "junaid@123")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@34511111111superSecretKey@34511111111")); // 64 characters
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokeOptions = new JwtSecurityToken(
                    issuer: "https://localhost:5001",
                    audience: "https://localhost:5001",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                resp.Data = tokenString;
                resp.Success = true;
                resp.Message = "Data fatched successfully.";
            }
            return resp;

        }
    }
}
