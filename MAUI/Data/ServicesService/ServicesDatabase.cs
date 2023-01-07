using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.ServicesService
{
    public class ServicesDatabase
    {
        IServicesService ServicesService;

        public ServicesDatabase(IServicesService service)
        {
            ServicesService = service;
        }
        public Task<List<Services>> GetServicesAsync()
        {
            return ServicesService.RefreshDataAsync();
        }

        public Task SaveServicesAsync(Services item, bool isNewItem = true)
        {
            return ServicesService.SaveServicesAsync(item, isNewItem);
        }
       

        public Task<List<Services>> CheckUserAsync(string id)
        {
            return ServicesService.CheckUserAsync(id);
        }
      
    }
}    
