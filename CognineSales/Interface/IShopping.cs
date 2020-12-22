using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognineSales.Models;

namespace CognineSales.Interface
{
    public interface IShopping
    {
        Task<Roledata> RoleIdentity(Login login);
        Task<bool> SaveUser(Userdata userdata);
        Task SaveData(Userdata userdata);
        Task SaveCustomer(Userdata userdata, int UserId);
        Task SaveStaff(Userdata userdata, int UserId);
        Task SaveStore(Userdata userdata, int UserId);

    }
}
