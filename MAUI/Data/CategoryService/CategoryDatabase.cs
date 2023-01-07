using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.CategoryService
{
    public class CategoryDatabase
    {
        ICategoryService CategoryService;
       
        public CategoryDatabase(ICategoryService service)
        {
            CategoryService = service;
        }
        public Task<List<Category>> GetCategoryAsync()
        {
            return CategoryService.RefreshDataAsync();
        }

        public Task SaveCategoryAsync(Category item, bool isNewItem = true)
        {
            return CategoryService.SaveCategoryAsync(item, isNewItem);
        }
        public Task DeleteCategoryAsync(Category item)
        {
            return CategoryService.DeleteCategoryAsync(item.Id);
        }

    }
}    
