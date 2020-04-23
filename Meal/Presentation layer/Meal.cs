using DailyMeal.Servive_Layer;
using Meal.Buiseness_layer;
using Meal.Data_layer;
using Meal.Presentation_layer;
using Meal.Service_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Meal
{
    public partial class Meal : Form
    {

        User user = new User();
        public static readonly IService service = new Service();
        public List<Category> categories = service.GetCategories();
        public DailyRation currentRation = service.GetBasicRation();
        public TreeNode categoryRootNode = new TreeNode("Категории");
        public double RationCalories = 0;

        public Meal()
        {
            InitializeComponent();
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;
            treeView1.Nodes.Add(categoryRootNode);
            categoryRootNode.ImageIndex = 0;
            for (int i = 0; i < categories.Count; i++)
            {
                categoryRootNode.Nodes.Add(categories[i].Name);
                categoryRootNode.Nodes[i].ImageIndex = i + 1;
                categoryRootNode.Nodes[i].SelectedImageIndex = 26;
                for (int j = 0; j < categories[i].products.Count; j++)
                {
                    categoryRootNode.Nodes[i].Nodes.Add(categories[i].products[j].Name);
                    categoryRootNode.Nodes[i].Nodes[j].ImageIndex = i + 1;
                    categoryRootNode.Nodes[i].Nodes[j].SelectedImageIndex = 26;
                }
            }
            treeView2.ImageList = imageList2;
            for (int i = 0; i < currentRation.MealTimes.Count; i++)
            {
                treeView2.Nodes.Add(currentRation.MealTimes[i].Name);
                treeView2.Nodes[i].ImageIndex = i;
                treeView2.Nodes[i].SelectedImageIndex = i;
                for (int j = 0; j < currentRation.MealTimes[i].mealtimeProducts.Count; j++)
                {
                    treeView2.Nodes[i].Nodes.Add(currentRation.MealTimes[i].mealtimeProducts[j].Name);
                    RationCalories += currentRation.MealTimes[i].mealtimeProducts[j].Calories;
                }
            }
            RationCaloriesBox.Text = Convert.ToString(RationCalories + " Ккал");
        }
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }
        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void treeView2_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            treeView1.SelectedNode = treeView1.GetNodeAt(targetPoint);
        }

        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView2.PointToClient(new Point(e.X, e.Y));

            TreeNode targetNode = treeView2.GetNodeAt(targetPoint);

            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (draggedNode.Parent != categoryRootNode)
            {
                if (e.Effect == DragDropEffects.Copy)
                {
                    if (targetNode.Parent == null)
                    {
                        targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                        for (int i = 0; i < treeView2.Nodes.Count; i++)
                        {
                            for (int j = 0; j < treeView2.Nodes[i].Nodes.Count; j++)
                            {
                                treeView2.Nodes[i].Nodes[j].ImageIndex = 3;
                                treeView2.Nodes[i].Nodes[j].SelectedImageIndex = 3;
                                treeView2.Refresh();
                            }
                        }
                        Product product = service.GetProduct(draggedNode.Text);
                        service.AddProductToMealTime(product, currentRation.MealTimes[targetNode.Index]);
                        RationCalories += product.Calories;
                        RationCaloriesBox.Text = Convert.ToString(RationCalories + " Ккал");
                    }
                }
            }
            targetNode.Expand();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void caloryButton_Click(object sender, EventArgs e)
        {
            if (AgeBox.Text != string.Empty && WeightBox.Text != string.Empty && HeightBox.Text != string.Empty && NameBox.Text != string.Empty)
            {
                int age;
                int height;
                int weight;
                if (!int.TryParse(AgeBox.Text, out age) || !int.TryParse(HeightBox.Text, out height) || !int.TryParse(WeightBox.Text, out weight))
                {
                    if (!int.TryParse(AgeBox.Text, out age))
                    {
                        AgeBox.Text = string.Empty;
                    }
                    if (!int.TryParse(HeightBox.Text, out height))
                    {
                        HeightBox.Text = string.Empty;
                    }
                    if (!int.TryParse(WeightBox.Text, out weight))
                    {
                        WeightBox.Text = string.Empty;
                    }
                    MessageBox.Show("Все поля, кроме имени, должны принимать числовые значения!", "Ошибка Ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    user.Name = NameBox.Text;
                    user.Age = age;
                    user.Height = height;
                    user.Weight = weight;
                    NameBox.Enabled = false;
                    AgeBox.Enabled = false;
                    HeightBox.Enabled = false;
                    WeightBox.Enabled = false;
                    if (lowActivity.Checked)
                    {
                        user.ActivityType = lowActivity.Text;
                        normalActivity.Enabled = false;
                        middleActivity.Enabled = false;
                        highActivity.Enabled = false;
                    }
                    else if (normalActivity.Checked)
                    {
                        user.ActivityType = normalActivity.Text;
                        lowActivity.Enabled = false;
                        middleActivity.Enabled = false;
                        highActivity.Enabled = false;
                    }
                    else if(middleActivity.Checked)
                    {
                        user.ActivityType = middleActivity.Text;
                        normalActivity.Enabled = false;
                        lowActivity.Enabled = false;
                        highActivity.Enabled = false;
                    }
                    else if(highActivity.Checked)
                    {
                        user.ActivityType = highActivity.Text;
                        normalActivity.Enabled = false;
                        middleActivity.Enabled = false;
                        lowActivity.Enabled = false;
                    }
                    CaloryCounterBox.Text = Convert.ToString(service.DailyColoriesRate(user) + " Ккал");
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены!","Пропущены поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode;
                    break;
                }
                if (StartNode.Nodes.Count != 0)
                {
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        break;
                    }
                }
                StartNode = StartNode.NextNode;
            }
            return node;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SearchText = SearchBox.Text;
            if (SearchText == "")
            {
                return;
            }
            TreeNode SelectedNode = SearchNode(SearchText, treeView1.Nodes[0]);
            if (SelectedNode != null)
            {
                treeView1.SelectedNode = SelectedNode;
                treeView1.SelectedNode.Expand();
                treeView1.Select();
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Parent != null)
            {
                Product product = service.GetProduct(e.Node.Text);
                groupBox3.Text = product.Name;
                proteinBox.Text = Convert.ToString(product.Protein);
                fatsBox.Text = Convert.ToString(product.Fats);
                carbsBox.Text = Convert.ToString(product.Carbs);
                caloriesBox.Text = Convert.ToString(product.Calories);
                gramsBox.Text = Convert.ToString(product.Gramms);
                gramsTrackBar.Value = product.Gramms;
            }
        }

        private void gramsTrackBar_Move(object sender, EventArgs e)
        {

        }

        private void gramsTrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                Product product = service.GetProduct(groupBox3.Text);
                double bufCalories = 0;
                bufCalories = (product.Calories * gramsTrackBar.Value) / product.Gramms;
                product.Gramms = gramsTrackBar.Value;
                gramsBox.Text = Convert.ToString(product.Gramms);
                RationCalories = RationCalories - product.Calories + bufCalories;
                product.Calories = bufCalories;
                caloriesBox.Text = Convert.ToString(product.Calories);
                RationCaloriesBox.Text = Convert.ToString(RationCalories + " Ккал");
            }
            catch
            {
                MessageBox.Show("Выберите продукт из списка приемов пищи!","Продукт не выбран", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gramsTrackBar.Value = gramsTrackBar.Minimum;
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Parent == null)
            {
                AddCategoryForm addForm = new AddCategoryForm();
                addForm.Owner = this;
                addForm.Show();
            }
            else if (treeView1.SelectedNode.Parent.Parent != null || treeView1.SelectedNode.Parent == categoryRootNode)
            {
                AddProductForm addForm = new AddProductForm();
                addForm.Owner = this;
                addForm.Show();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent == categoryRootNode)
            {
                int index = treeView1.SelectedNode.Index;
                treeView1.SelectedNode.Remove();
                service.DeleteCategory(index);
            }
            else if (treeView1.SelectedNode.Parent.Parent == categoryRootNode)
            {
                int index = treeView1.SelectedNode.Index;
                treeView1.SelectedNode.Remove();
                service.DeleteProduct(index, treeView1.SelectedNode.Parent.Text);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < currentRation.MealTimes.Count; i++)
            {
                treeView2.Nodes[i].Nodes.Clear();
                for(int j = 0; j < currentRation.MealTimes[i].mealtimeProducts.Count; j++)
                {
                    service.DeleteProductFromMealTime(currentRation.MealTimes[i],j);
                }
            }
            for (int i = currentRation.MealTimes.Count - 1; i >= 0; i--)
            {
                if(i > 2)
                {
                    service.DeleteMealTime(currentRation, i);
                    treeView2.Nodes[i].Remove();
                }
            }
            groupBox3.Text = "Продукт не выбран";
            proteinBox.Text = string.Empty;
            fatsBox.Text = string.Empty;
            carbsBox.Text = string.Empty;
            caloriesBox.Text = string.Empty;
            gramsBox.Text = string.Empty;
            RationCalories = 0;
            RationCaloriesBox.Text = Convert.ToString(RationCalories + " Ккал");
        }

        private void AddMealTimeButton_Click(object sender, EventArgs e)
        {
            AddMealTimeForm addForm = new AddMealTimeForm();
            addForm.Owner = this;
            addForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(CaloryCounterBox.Text == string.Empty || RationCalories == 0)
            {
                MessageBox.Show("Не заполнены поля дневной нормы или рацион пуст!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                service.ExportRation(CaloryCounterBox.Text, RationCaloriesBox.Text, user, currentRation);
                MessageBox.Show("Файл готов.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            NameBox.Enabled = true;
            AgeBox.Enabled = true;
            HeightBox.Enabled = true;
            WeightBox.Enabled = true;
            lowActivity.Enabled = true;
            normalActivity.Enabled = true;
            middleActivity.Enabled = true;
            highActivity.Enabled = true;
        }
    }
}
