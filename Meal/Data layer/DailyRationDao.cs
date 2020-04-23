using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Meal.Data_layer
{
    public class DailyRationDao : IDailyRationDao
    {
        private DataBase db = DataBase.GetDataBaseInstance();

        public void AddMealTime(MealTime mealTime, DailyRation ration)
        {
            ration.MealTimes.Add(mealTime);
        }
        public DailyRation GetBasicRation()
        {
            return db.basicRation;
        }
        public void DeleteMealTime(DailyRation ration, int index)
        {
            ration.MealTimes.RemoveAt(index);
        }
        public void ExportRation(string sum, string daily_norm, User user, DailyRation ration)
        {
            XFont small_font = new XFont("sans-serif", 15, XFontStyle.Regular);
            XFont large_font = new XFont("sans-serif", 18, XFontStyle.Regular);
            XFont xlarge_font = new XFont("sans-serif", 25, XFontStyle.Regular);
            int x = 40, y = 10;

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Мой дневной рацион";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            gfx.DrawString("Мой дневной рацион",
            xlarge_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 35;
            gfx.DrawString("Информация о пользователе",
            large_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 25;
            gfx.DrawString($"Имя: {user.Name}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Возраст: {user.Age}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Рост: {user.Height}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Вес: {user.Weight}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 25;
            gfx.DrawString($"Тип Активности: {user.ActivityType}",
            small_font, XBrushes.Black,
            new XRect(x + 20, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 30;
            gfx.DrawString($"Рекомендуемая дневная норма: {daily_norm}",
            xlarge_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            foreach (MealTime meal in ration.MealTimes)
            {
                y += 35;
                if (y + 35 > page.Height)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    y = 10;
                }
                gfx.DrawString(meal.Name,large_font, XBrushes.Black, new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
                foreach (Product product in meal.mealtimeProducts)
                {
                    y += 25;
                    if (y + 25 > page.Height)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        y = 10;
                    }
                    gfx.DrawString($"{product.Name}: {product.Gramms} грамм",
                    small_font, XBrushes.Black,
                    new XRect(x + 25, y, page.Width, page.Height), XStringFormats.TopLeft);
                }
            }
            y += 50;
            if (y > page.Height)
            {
                page = document.AddPage();
                gfx = XGraphics.FromPdfPage(page);
                y = 0;
            }
            gfx.DrawString($"Калорийность рациона: {sum}",
            xlarge_font, XBrushes.Black,
            new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);

            const string filename = "Daily Food Ration.pdf";
            document.Save(filename);
        }
    }
}
