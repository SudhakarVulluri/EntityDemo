using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CognineSales.Interface;
using CognineSales.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CognineSales.Repository
{
    public class Shopping : IShopping
    {
        private ShoppingDbContext _dbContext;
        public Shopping(ShoppingDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<Roledata> RoleIdentity(Login login)
        {
            Roledata role = new Roledata();
            var data =await _dbContext.AllUsers.Where(x => x.Email == login.UserEmail && x.Password == login.UserPassword).Select(x => new Roledata { CustomerId=x.Id,RoleId=x.RollId }).FirstOrDefaultAsync();
            role.CustomerId = data.CustomerId;
            role.RoleId = data.RoleId;
            return role; 
        }
        public async Task<bool> SaveUser(Userdata userdata)
        {
            var uniqueEmail = await _dbContext.AllUsers.Where(x => x.Email == userdata.Email).FirstOrDefaultAsync();
            if (uniqueEmail == null)
            {
                AllUsers user = new AllUsers();
                user.Name = userdata.FirstName + " " + userdata.LastName;
                user.Email = userdata.Email;
                user.Password = userdata.Password;
                user.RollId = 2;

                await _dbContext.AllUsers.AddAsync(user);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            else
                return false;
        }
        public async Task<bool> GetUserId(Userdata userdata)
        {
            var data = await _dbContext.AllUsers.Where(x => x.Email == userdata.Email).Select(x=>x.Id).FirstOrDefaultAsync();
            if (data != 0)
            {
                Customer user = new Customer();
                user.CustomerId = Convert.ToInt32(data);
                user.FirstName = userdata.FirstName;
                user.LastName = userdata.LastName;
                user.Gender = userdata.Gender;
                user.Phone = userdata.Phone;
                user.Street = userdata.Street;
                user.City = userdata.City;
                user.State = userdata.State;
                user.PinCode = userdata.PinCode;
                user.Country = userdata.Country;
                user.IsActive = true;

                await _dbContext.Customer.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }
        //public async Task CreateAuthenticationTicket(Login user)
        //{
        //    var key = Encoding.ASCII.GetBytes(SiteKeys.Token);
        //    var JWToken = new JwtSecurityToken(
        //    issuer: SiteKeys.WebSiteDomain,
        //    audience: SiteKeys.WebSiteDomain,
        //    claims: GetUserClaims(user),
        //    notBefore: new DateTimeOffset(DateTime.Now).DateTime,
        //    expires: new DateTimeOffset(DateTime.Now.AddDays(1)).DateTime,
        //    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //);

        //    var token = new JwtSecurityTokenHandler().WriteToken(JWToken);
        //    HttpContext.Session.SetString("JWToken", token);
        //}


        //private IEnumerable<Claim> GetUserClaims(Login user)
        //{
        //    List<Claim> claims = new List<Claim>();
        //    Claim _claim;
        //    _claim = new Claim(ClaimTypes.Name, user.UserEmail);
        //    claims.Add(_claim);

        //    _claim = new Claim("Role", Roles.Admin);
        //    claims.Add(_claim);

        //    return claims.AsEnumerable<Claim>();
        //}
    }
}
