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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meal meal = this.Owner as Meal;
            int grams = 0;
            double protein = 0;
            double fats = 0;
            double calories = 0;
            double carbs = 0;
            if (NameBox.Text == string.Empty || ProteinBox.Text == string.Empty || GramsBox.Text == string.Empty || FatsBox.Text == string.Empty || CaloriesBox.Text == string.Empty || CarbsBox.Text == string.Empty || !double.TryParse(ProteinBox.Text, out protein) || !int.TryParse(GramsBox.Text, out grams) || !double.TryParse(FatsBox.Text, out fats) || !double.TryParse(CaloriesBox.Text, out calories) || !double.TryParse(CarbsBox.Text, out carbs))
            {
                if (NameBox.Text == string.Empty)
                {
                    NameBox.BackColor = Color.Orange;
                }
                if (ProteinBox.Text == string.Empty || !double.TryParse(ProteinBox.Text, out protein))
                {
                    ProteinBox.BackColor = Color.Orange;
                }
                if (GramsBox.Text == string.Empty || !int.TryParse(GramsBox.Text, out grams))
                {
                    GramsBox.BackColor = Color.Orange;
                }
                if (FatsBox.Text == string.Empty || !double.TryParse(FatsBox.Text, out fats))
                {
                    FatsBox.BackColor = Color.Orange;
                }
                if (CaloriesBox.Text == string.Empty || !double.TryParse(CaloriesBox.Text, out calories))
                {
                    CaloriesBox.BackColor = Color.Orange;
                }
                if (CarbsBox.Text == string.Empty || !double.TryParse(CarbsBox.Text, out carbs))
                {
                    CarbsBox.BackColor = Color.Orange;
                }
                MessageBox.Show("Не заполнено обязательное поле или формат введенных данных неверен!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Product product = new Product();
                product.Name = NameBox.Text;
                product.Gramms = int.Parse(GramsBox.Text);
                product.Protein = double.Parse(ProteinBox.Text);
                product.Fats = double.Parse(FatsBox.Text);
                product.Carbs = double.Parse(CarbsBox.Text);
                product.Calories = double.Parse(CaloriesBox.Text);
                if (product.IsValid())
                {
                    int index = meal.treeView1.SelectedNode.Index; ;
                    if (meal.treeView1.SelectedNode.Parent == meal.categoryRootNode)
                    {
                        Meal.service.AddProduct(product, meal.treeView1.SelectedNode.Text);
                    }
                    else
                    {
                        Meal.service.AddProduct(product, meal.treeView1.SelectedNode.Parent.Text);
                        index = meal.treeView1.SelectedNode.Parent.Index;
                    }
                    meal.categoryRootNode.Nodes[index].Nodes.Add(product.Name);
                    meal.categoryRootNode.Nodes[index].Nodes[meal.categories[index].products.Count - 1].ImageIndex = 27;
                    meal.categoryRootNode.Nodes[index].Nodes[meal.categories[index].products.Count - 1].SelectedImageIndex = 26;
                    meal.treeView1.Refresh();
                    meal.treeView1.SelectedNode.Expand();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не верные значения для продукта", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
