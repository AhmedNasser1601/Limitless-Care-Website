using Limitless_Care_Website.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Limitless.Services.Services.Account
{
    public interface IAccountServices
    {
        public ResultViewModel Register(RegisterViewModel model);
        public ResultViewModel Login(LoginViewModel model);
        public void SignOut();
    }
}
