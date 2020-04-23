using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public class MealTimeDao : IMealTimeDao
    {
        public void AddProductToMeaalTime(Product product, MealTime meal)
        {
            meal.mealtimeProducts.Add(product);
        }
        public void DeleteProductFromMealTime(MealTime meal, int index)
        {
            meal.mealtimeProducts.RemoveAt(index);
        }
    }
}
