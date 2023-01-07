using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.UsersService
{
    public interface IUsersService
    {
        Task<List<Users>> RefreshDataAsync();
        Task SaveUsersAsync(Users item, bool isNewItem);
        Task DeleteUsersAsync(string id);
        Task<List<Users>> CheckUserAsync(string id);
    }
}
