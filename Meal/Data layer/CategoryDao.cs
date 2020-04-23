using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Meal.Buiseness_layer;

namespace Meal.Data_layer
{
    public class CategoryDao : ICategoryDao
    {
        private DataBase db = DataBase.GetDataBaseInstance();
        public List<Category> GetCategories()
        {
            return db.resultCategories;
        }
        public void AddCategory(Category category)
        {
            db.resultCategories.Add(category);
        }
        public void DeleteCategory(int index)
        {
            db.resultCategories.RemoveAt(index);
        }
    }
}
