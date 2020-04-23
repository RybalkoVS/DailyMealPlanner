using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Buiseness_layer
{
    public class MealTime
    {

        public List<Product> mealtimeProducts = new List<Product>();

        public string Name { get; set; }

        public MealTime()
        {

        }
        public MealTime(string name)
        {
            Name = name;
        }
    }
}
