using Meal.Business_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Meal.Buiseness_layer
{
    public class Category : BusinessObject
    {
        public List<Product> products = new List<Product>();
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsValid()
        {
            return CategoryValidation(this);
        }

        public Category()
        {

        }
        
    }
}
