using Meal.Buiseness_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal.Presentation_layer
{
    public partial class AddMealTimeForm : Form
    {
        public AddMealTimeForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Meal meal = this.Owner as Meal;
            if(NameBox.Text == string.Empty)
            {
                NameBox.BackColor = Color.Orange;
                MessageBox.Show("Не заполнены обязательные поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MealTime mealTime = new MealTime(NameBox.Text);
                Meal.service.AddMealTime(mealTime, meal.currentRation);
                meal.treeView2.Nodes.Add(mealTime.Name);
                meal.treeView2.Nodes[meal.currentRation.MealTimes.Count - 1].ImageIndex = 4;
                meal.treeView2.Nodes[meal.currentRation.MealTimes.Count - 1].SelectedImageIndex = 3;
                Close();
            }
        }
    }
}
