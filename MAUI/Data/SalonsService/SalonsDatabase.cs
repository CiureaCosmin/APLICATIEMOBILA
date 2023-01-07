using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.SalonsService
{
    public class SalonsDatabase
    {
        ISalonsService SalonsService;
       
        public SalonsDatabase(ISalonsService service)
        {
            SalonsService = service;
        }
        public async Task<IEnumerable<Salons>> GetSalonsAsync(int category = 0)
        {
            // Get all salons
            var salons = await SalonsService.RefreshDataAsync();

            // If a category is specified, filter the salons by category
            if (category != 0)
            {
                salons = salons.Where(s => s.CategoryId == category).ToList();
            }

            return salons;
          
        }

        public Task SaveSalonsAsync(Salons item, bool isNewItem = true)
        {
            return SalonsService.SaveSalonsAsync(item, isNewItem);
        }
        public Task DeleteSalonsAsync(Salons item)
        {
            return SalonsService.DeleteSalonsAsync(item.Id);
        }
        public Task<List<Salons>> CheckSalonAsync(string id)
        {
            return SalonsService.CheckSalonAsync(id);
        }
    }
}    
