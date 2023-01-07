using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.SalonsService
{
    public interface ISalonsService
    {
        Task<List<Salons>> RefreshDataAsync();
        Task SaveSalonsAsync(Salons item, bool isNewItem);
        Task DeleteSalonsAsync(string id);
        Task<List<Salons>> CheckSalonAsync(string id);
    }
}
