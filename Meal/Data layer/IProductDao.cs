using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public interface IProductDao
    {
        void AddProduct(Product product, string categoryName);
        void DeleteProduct(int index, string categoryName);
        Product GetProduct(string name);
    }
}
