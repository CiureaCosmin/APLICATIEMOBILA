using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.ServicesService
{
    public interface IServicesService
    {
        Task<List<Services>> RefreshDataAsync();
        Task SaveServicesAsync(Services item, bool isNewItem);
        Task DeleteServicesAsync(string id);
        Task<List<Services>> CheckUserAsync(string id);
    }
}
