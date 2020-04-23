using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public class ProductDao : IProductDao
    {
        private DataBase db = DataBase.GetDataBaseInstance();

        public void AddProduct(Product product, string categoryName)
        {
            for(int i = 0; i < db.resultCategories.Count; i++)
            {
                if(db.resultCategories[i].Name == categoryName)
                {
                    db.resultCategories[i].products.Add(product);
                }
            }
        }
        public void DeleteProduct(int index, string categoryName)
        {
            for (int i = 0; i < db.resultCategories.Count; i++)
            {
                if (db.resultCategories[i].Name == categoryName)
                {
                    db.resultCategories[i].products.RemoveAt(index);
                }
            }
        }
        public Product GetProduct(string name)
        {
            for (int i = 0; i < db.resultCategories.Count; i++)
            {
                for (int j = 0; j < db.resultCategories[i].products.Count; j++)
                {
                    if (name == db.resultCategories[i].products[j].Name)
                    {
                        return db.resultCategories[i].products[j];
                    }
                }
            }
            return null;
        }
    }
}
