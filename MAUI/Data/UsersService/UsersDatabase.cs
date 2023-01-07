using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.UsersService
{
    public class UsersDatabase
    {
        IUsersService UsersService;

        public UsersDatabase(IUsersService service)
        {
            UsersService = service;
        }
        public Task<List<Users>> GetUsersAsync()
        {
            return UsersService.RefreshDataAsync();
        }

        public Task SaveUsersAsync(Users item, bool isNewItem = true)
        {
            return UsersService.SaveUsersAsync(item, isNewItem);
        }
        public Task DeleteUsersAsync(Users item)
        {
            return UsersService.DeleteUsersAsync(item.Id);
        }

        public Task<List<Users>> CheckUserAsync(string id)
        {
            return UsersService.CheckUserAsync(id);
        }
      
    }
}    
