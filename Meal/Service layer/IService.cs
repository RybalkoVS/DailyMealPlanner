using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Service_layer
{
    public interface IService
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
        void DeleteCategory(int index);

        void AddProduct(Product product, string categoryName);
        void DeleteProduct(int Index, string categoryName);
        Product GetProduct(string name);

        void AddProductToMealTime(Product product, MealTime meal);
        void DeleteProductFromMealTime(MealTime meal, int index);
        void AddMealTime(MealTime mealTime, DailyRation ration);
        DailyRation GetBasicRation();
        void DeleteMealTime(DailyRation ration, int index);
        void ExportRation(string sum, string daily_norm, User user, DailyRation ration);

        double DailyColoriesRate(User user);
    }
}
