using Meal.Buiseness_layer;
using Meal.Data_layer;
using Meal.Service_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyMeal.Servive_Layer
{
    public class Service : IService
    {
        static readonly ICategoryDao categoryDao = new CategoryDao();
        static readonly IProductDao productDao = new ProductDao();
        static readonly IUserDao userDao = new UserDao();
        static readonly IDailyRationDao rationDao = new DailyRationDao();
        static readonly IMealTimeDao mealDao = new MealTimeDao();

        public Service()
        {

        }

        public List<Category> GetCategories()
        {
            return categoryDao.GetCategories();
        }
        public Product GetProduct(string name)
        {
            return productDao.GetProduct(name);
        }
        public void AddProduct(Product product, string categoryName)
        {
            productDao.AddProduct(product, categoryName);
        }
        public void DeleteProduct(int index, string categoryName)
        {
            productDao.DeleteProduct(index, categoryName);
        }
        public void AddCategory(Category category)
        {
            categoryDao.AddCategory(category);
        }

        public void DeleteCategory(int index)
        {
            categoryDao.DeleteCategory(index);
        }

        public double DailyColoriesRate(User user)
        {
            return userDao.DailyColoriesRate(user);
        }
        public void AddProductToMealTime(Product product, MealTime meal)
        {
            mealDao.AddProductToMeaalTime(product, meal);
        }
        public void DeleteProductFromMealTime(MealTime meal, int index)
        {
            mealDao.DeleteProductFromMealTime(meal, index);
        }
        public void AddMealTime(MealTime mealTime, DailyRation ration)
        {
            rationDao.AddMealTime(mealTime, ration);
        }
        public DailyRation GetBasicRation()
        {
            return rationDao.GetBasicRation();
        }
        public void DeleteMealTime(DailyRation ration, int index)
        {
            rationDao.DeleteMealTime(ration, index);
        }
        public void ExportRation(string sum, string daily_norm, User user, DailyRation ration)
        {
            rationDao.ExportRation(sum, daily_norm, user, ration);
        }
    }
}
