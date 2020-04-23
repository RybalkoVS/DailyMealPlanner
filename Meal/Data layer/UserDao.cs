using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meal.Data_layer
{
    public class UserDao : IUserDao
    {
        public double DailyColoriesRate(User user)
        {
            double BMR = 447.593 + (9.247 * user.Weight) + (3.098 * user.Height) - (4.330 * user.Age);
            if (user.ActivityType == "Низкая")
            {
                return BMR * 1.2;
            }
            if (user.ActivityType == "Умеренная")
            {
                return BMR * 1.375;
            }
            if (user.ActivityType == "Средняя")
            {
                return BMR * 1.55;
            }
            return BMR * 1.725;
        }
    }
}
