using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Business_layer
{
    public class BusinessObject
    {
        public bool ProductValidation(Product product)
        {
            if(product.Name == string.Empty || product.Name.Length > 100)
            {
                return false;
            }
            if(product.Gramms < 1)
            {
                return false;
            }
            if(product.Carbs < 0 || product.Fats < 0 || product.Calories < 0 || product.Protein < 0)
            {
                return false;
            }
            return true;
        }
        public bool CategoryValidation(Category category)
        {
            if(category.Name == string.Empty || category.Name.Length > 100)
            {
                return false;
            }
            return true;
        }
    }
}
