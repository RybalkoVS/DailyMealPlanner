﻿using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public interface IMealTimeDao
    {
        void AddProductToMeaalTime(Product product, MealTime meal);
        void DeleteProductFromMealTime(MealTime meal, int index);
    }
}
