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
    public class UserDetails
    {
        public int UserId { get; set; }
        public int RollId { get; set; }
    }
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
            role = await _dbContext.AllUsers.Where(x => x.Email == login.UserEmail && x.Password == login.UserPassword).Include("Roles").Select(x=> new Roledata{Name = x.Name, RoleName = x.Roles.RollName,Email = x.Email,Id = x.Id }).FirstOrDefaultAsync();
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
                if (userdata.Name == null && userdata.ManagerId == 0)
                {
                    user.Name = userdata.FirstName + " " + userdata.LastName;
                    user.Email = userdata.Email;
                    user.Password = userdata.Password;
                    user.RollId = 2;
                }
                else if(userdata.Name == null)
                {
                    user.Name = userdata.FirstName + " " + userdata.LastName;
                    user.Email = userdata.Email;
                    user.Password = userdata.Password;
                    user.RollId = 3;
                }
                else if(userdata.Name!=null)
                {
                    user.Name = userdata.Name;
                    user.Email = userdata.Email;
                    user.Password = userdata.Password;
                    user.RollId = 4;
                }
                await _dbContext.AllUsers.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task SaveData(Userdata userdata)
        {
            var data = await _dbContext.AllUsers.Where(x => x.Email == userdata.Email).Select(x => new UserDetails {UserId = x.Id, RollId = x.RollId } ).FirstOrDefaultAsync();
            if (data.RollId == 2)
            {
                await SaveCustomer(userdata,data.UserId);
            }
            else if (data.RollId == 3)
            {
                await SaveStaff(userdata, data.UserId);
            }
            else if(data.RollId == 4)
            {
                await SaveStore(userdata, data.UserId);
            }
        }
        public async Task SaveCustomer(Userdata userdata, int UserId)
        {
            Customer user = new Customer();
            user.CustomerId = UserId;
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
        }
        public async Task SaveStaff(Userdata userdata, int UserId)
        {
            Staff user = new Staff();
            user.StaffId = UserId;
            user.FirstName = userdata.FirstName;
            user.LastName = userdata.LastName;
            user.Gender = userdata.Gender;
            user.Phone = userdata.Phone;
            user.Street = userdata.Street;
            user.City = userdata.City;
            user.State = userdata.State;
            user.PinCode = userdata.PinCode;
            user.Country = userdata.Country;
            user.Active = true;
            user.StoreId = Convert.ToInt32(userdata.StoreId);
            await _dbContext.Staff.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
        public async Task SaveStore(Userdata userdata, int UserId)
        {
            Stores user = new Stores();
            user.StoreId = UserId;
            user.Name = userdata.Name;
            user.Phone = userdata.Phone;
            user.Street = userdata.Street;
            user.City = userdata.City;
            user.State = userdata.State;
            user.PinCode = userdata.PinCode;
            user.Country = userdata.Country;
            user.IsActive = true;
            await _dbContext.Stores.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
