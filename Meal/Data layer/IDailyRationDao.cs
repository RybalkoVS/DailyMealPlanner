using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public interface IDailyRationDao
    {
        DailyRation GetBasicRation();
        void AddMealTime(MealTime mealTime, DailyRation ration);
        void DeleteMealTime(DailyRation ration, int index);
        void ExportRation(string sum, string daily_norm, User user, DailyRation ration);
    }
}
