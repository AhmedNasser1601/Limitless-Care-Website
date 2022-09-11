using Limitless_Care_Website.Data;
using Limitless_Care_Website.Logic.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Limitless.Services.Services.Account
{

    public class AccountServices :  IAccountServices
    {
        UserManager<IdentityUser> UserManager;
        private readonly IConfigurationSection _JWTSettings;
        SignInManager<IdentityUser> signInManager;

        public AccountServices(UserManager<IdentityUser> UserManager,  SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            this.UserManager = UserManager;
        
            _JWTSettings = configuration.GetSection("JWTSettings");
            this.signInManager = signInManager;
        }
        public ResultViewModel Register(RegisterViewModel Model)
        {
            var Data = new Admin
            {
                UserName = Model.UserName,
                Name = Model.Name,
                PhoneNumber = Model.PhoneNumber,
                Email = Model.Email,
                Nationality = Model.Nationality
            };
            var Result = UserManager.CreateAsync(Data).Result;
            if (Result.Succeeded)
            {
                var s = UserManager.AddToRoleAsync(Data, Model.Role).Result;
                if (s.Succeeded)
                     Result = UserManager.AddPasswordAsync(Data, Model.Password).Result;
                if (Result.Succeeded)
                    return new ResultViewModel { IsSuccess = true, Message = "Register Success" };

            }
            return new ResultViewModel { IsSuccess = false, Message = "Invalid Register",Data = Result };
        }
            
        public ResultViewModel Login(LoginViewModel model)
        {
            var user = UserManager.FindByEmailAsync(model.Email).Result;

            if (user != null && UserManager.CheckPasswordAsync(user, model.Password).Result)
            {
                var signingCredentials = GetSigningCredentials();
                var claims = GetClaims(user).Result;
                var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return new ResultViewModel { IsSuccess = true, Data = token,Message="Logged Success." };
            }
            return new ResultViewModel { IsSuccess = false, Message = "Invalid username or password." };

        }
        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_JWTSettings.GetSection("securityKey").Value);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims(IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name , user.UserName),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.NameIdentifier , user.Id),
            };
            var roles = await UserManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _JWTSettings.GetSection("validIssuer").Value,
                audience: _JWTSettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_JWTSettings.GetSection("expiryInMinutes").Value)),
                signingCredentials: signingCredentials);
            return tokenOptions;
        }
        public void SignOut()
        {
            signInManager.SignOutAsync();
        }
        public bool ValidateJwtToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("CodeMazeSecretKey");
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    RequireExpirationTime = true,
                    ValidateLifetime = true,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);
                var jwtToken = (JwtSecurityToken)validatedToken;
                return true;
            }
            catch
            {
                
                return false;
            }
        }
    }
}
