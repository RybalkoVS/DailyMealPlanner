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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Meal meal = this.Owner as Meal;
            if(nameBox.Text == string.Empty)
            {
                MessageBox.Show("Не заполнено обязательное поле", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nameBox.BackColor = Color.Orange;
            }
            else
            {
                Category category = new Category();
                category.Name = nameBox.Text;
                category.Description = descriptionBox.Text;
                if (category.IsValid())
                {
                    Meal.service.AddCategory(category);
                    meal.treeView1.Nodes[0].Nodes.Add(category.Name);
                    meal.treeView1.Nodes[0].Nodes[meal.categories.Count - 1].ImageIndex = 27;
                    meal.treeView1.Nodes[0].Nodes[meal.categories.Count - 1].SelectedImageIndex = 26;
                    meal.treeView1.Refresh();
                    meal.treeView1.SelectedNode.Expand();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не верные значения для категории", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
