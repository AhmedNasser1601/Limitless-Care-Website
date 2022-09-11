using Limitless.Services.Services.Account;
using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Limitless_Care_Website.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices accountServices;
        public AccountController(IAccountServices accountServices)
        {
            this.accountServices = accountServices;
        }
        [HttpPost]
        [AllowAnonymous]
        public ResultViewModel Register(RegisterViewModel Model)
        {
          return  accountServices.Register(Model);
        }
        [HttpPost]
        [AllowAnonymous]
        public ResultViewModel Login(LoginViewModel Model)
        {
            return accountServices.Login(Model);
        }
        [Authorize]
        public void Signout()
        {
           accountServices.SignOut();
        }
        [HttpGet]
        [Authorize]
        public string GetRole()
        {
            string Role = User.FindFirstValue(ClaimTypes.Role);
            return Role;
        }
        [HttpPost]
        public bool Validate(string token)
        {
            return accountServices.ValidateJwtToken(token);
        }
    }
}
