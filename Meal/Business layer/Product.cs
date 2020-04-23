using Meal.Business_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Meal.Buiseness_layer
{
    public class Product : BusinessObject
    {
        public string Name { get; set; }
        public int Gramms { get; set; }
        public double Protein { get; set; }
        public double Fats { get; set; }
        public double Carbs { get; set; }
        public double Calories { get; set; }

        public bool IsValid()
        {
            return ProductValidation(this);
        }
        public Product()
        {

        }
    }
}
