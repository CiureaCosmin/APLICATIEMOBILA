using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> RefreshDataAsync();
        Task SaveCategoryAsync(Category item, bool isNewItem);
        Task DeleteCategoryAsync(int id);
    }
}
