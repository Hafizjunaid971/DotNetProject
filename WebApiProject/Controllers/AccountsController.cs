using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using WebApiProject.BusinessModel;
using WebApiProject.Data;
using System.Threading.Tasks;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel user)
        {

            
            var result = _accountService.Login(user);
            if (result.IsCompletedSuccessfully)
            {
                return Ok(new ResponseModel
                {
                    Success = result.Result.Success,
                    Message = result.Result.Message,
                    Data = result.Result.Data
                });

            }

            return Unauthorized(result);
        }
    }
}
