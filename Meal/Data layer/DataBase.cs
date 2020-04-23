using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Meal.Data_layer
{
    public class DataBase
    {
        private static DataBase dataBase;

        public static DataBase GetDataBaseInstance()
        {
            if (dataBase == null)
            {
                dataBase = new DataBase();
            }
            return dataBase;
        }

        private XDocument xdoc = XDocument.Load("FoodProducts.xml");
        public List<Category> resultCategories = new List<Category>();
        public DailyRation basicRation = new DailyRation();


        private DataBase()
        {
            GetData();
            GetRation();
        }

        public void GetRation()
        {
            List<MealTime> mealTimeList = new List<MealTime>();
            mealTimeList.Add(new MealTime("Завтрак"));
            mealTimeList.Add(new MealTime("Обед"));
            mealTimeList.Add(new MealTime("Ужин"));
            basicRation.MealTimes = mealTimeList;
        }

        public void GetData()
        {
            foreach (XElement CategoryElement in xdoc.Element("Db").Elements("Category"))
            {
                XAttribute nameAttribute = CategoryElement.Attribute("name");
                Category bufCategory = new Category();
                bufCategory.Name = nameAttribute.Value;
                List<Product> bufProducts = new List<Product>();
                foreach (XElement ProductElement in CategoryElement.Elements("Product"))
                {
                    Product bufProduct = new Product();
                    XElement nameElement = ProductElement.Element("Name");
                    XElement GrammsElement = ProductElement.Element("Gramms");
                    XElement ProteinElement = ProductElement.Element("Protein");
                    XElement FatsElement = ProductElement.Element("Fats");
                    XElement CarbsElement = ProductElement.Element("Carbs");
                    XElement CaloriesElement = ProductElement.Element("Calories");
                    bufProduct.Name = nameElement.Value;
                    bufProduct.Gramms = int.Parse(GrammsElement.Value);
                    bufProduct.Protein = double.Parse(ProteinElement.Value);
                    bufProduct.Fats = double.Parse(FatsElement.Value);
                    bufProduct.Carbs = double.Parse(CarbsElement.Value);
                    bufProduct.Calories = double.Parse(CaloriesElement.Value);
                    bufProducts.Add(bufProduct);
                }
                bufCategory.products = bufProducts;
                resultCategories.Add(bufCategory);
            }
        }
    }
}
