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
using CognineSales.Controllers;
using Microsoft.AspNetCore.Authentication.Cookies;

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
            role = await _dbContext.AllUsers.Where(x => x.Email == login.UserEmail && x.Password == login.UserPassword).Include("Roles").Select(x=> new Roledata{Name = x.Name, RoleName = x.Roles.RollName,Email = x.Email }).FirstOrDefaultAsync();
            if(role != null)
            {
                return role; 
            }
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
    }
}
