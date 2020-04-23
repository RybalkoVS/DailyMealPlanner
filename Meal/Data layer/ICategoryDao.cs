using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public interface ICategoryDao
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
        void DeleteCategory(int index);
    }
}
