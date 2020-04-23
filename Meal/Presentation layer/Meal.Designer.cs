namespace Meal
{
    partial class Meal
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lowActivity = new System.Windows.Forms.RadioButton();
            this.normalActivity = new System.Windows.Forms.RadioButton();
            this.middleActivity = new System.Windows.Forms.RadioButton();
            this.highActivity = new System.Windows.Forms.RadioButton();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.caloryButton = new System.Windows.Forms.Button();
            this.CaloryCounterBox = new System.Windows.Forms.TextBox();
            this.WeightBox = new System.Windows.Forms.TextBox();
            this.CaloryLabel = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.DailyRationLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.caloriesBox = new System.Windows.Forms.TextBox();
            this.gramsBox = new System.Windows.Forms.TextBox();
            this.carbsBox = new System.Windows.Forms.TextBox();
            this.fatsBox = new System.Windows.Forms.TextBox();
            this.proteinBox = new System.Windows.Forms.TextBox();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.gramsLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.fatsLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.gramsTrackBar = new System.Windows.Forms.TrackBar();
            this.RationCaloriesLabel = new System.Windows.Forms.Label();
            this.RationCaloriesBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddMealTimeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gramsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.ContextMenuStrip = this.Menu;
            this.treeView1.Location = new System.Drawing.Point(12, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(217, 527);
            this.treeView1.TabIndex = 0;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(127, 48);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lowActivity);
            this.groupBox1.Controls.Add(this.normalActivity);
            this.groupBox1.Controls.Add(this.middleActivity);
            this.groupBox1.Controls.Add(this.highActivity);
            this.groupBox1.Location = new System.Drawing.Point(64, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Активность";
            // 
            // lowActivity
            // 
            this.lowActivity.AutoSize = true;
            this.lowActivity.Location = new System.Drawing.Point(6, 21);
            this.lowActivity.Name = "lowActivity";
            this.lowActivity.Size = new System.Drawing.Size(61, 19);
            this.lowActivity.TabIndex = 4;
            this.lowActivity.Text = "Низкая";
            this.lowActivity.UseVisualStyleBackColor = true;
            // 
            // normalActivity
            // 
            this.normalActivity.AutoSize = true;
            this.normalActivity.Location = new System.Drawing.Point(6, 44);
            this.normalActivity.Name = "normalActivity";
            this.normalActivity.Size = new System.Drawing.Size(80, 19);
            this.normalActivity.TabIndex = 5;
            this.normalActivity.Text = "Умеренная";
            this.normalActivity.UseVisualStyleBackColor = true;
            // 
            // middleActivity
            // 
            this.middleActivity.AutoSize = true;
            this.middleActivity.Location = new System.Drawing.Point(6, 67);
            this.middleActivity.Name = "middleActivity";
            this.middleActivity.Size = new System.Drawing.Size(68, 19);
            this.middleActivity.TabIndex = 6;
            this.middleActivity.Text = "Средняя";
            this.middleActivity.UseVisualStyleBackColor = true;
            // 
            // highActivity
            // 
            this.highActivity.AutoSize = true;
            this.highActivity.Checked = true;
            this.highActivity.Location = new System.Drawing.Point(6, 90);
            this.highActivity.Name = "highActivity";
            this.highActivity.Size = new System.Drawing.Size(69, 19);
            this.highActivity.TabIndex = 7;
            this.highActivity.TabStop = true;
            this.highActivity.Text = "Высокая";
            this.highActivity.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchBox.Location = new System.Drawing.Point(12, 5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(217, 20);
            this.SearchBox.TabIndex = 4;
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView2.Location = new System.Drawing.Point(537, 33);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(180, 225);
            this.treeView2.TabIndex = 5;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseDoubleClick);
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            this.treeView2.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView2_DragOver);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.ChangeButton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.HeightBox);
            this.groupBox2.Controls.Add(this.caloryButton);
            this.groupBox2.Controls.Add(this.CaloryCounterBox);
            this.groupBox2.Controls.Add(this.WeightBox);
            this.groupBox2.Controls.Add(this.CaloryLabel);
            this.groupBox2.Controls.Add(this.AgeBox);
            this.groupBox2.Controls.Add(this.NameBox);
            this.groupBox2.Controls.Add(this.NameLabel);
            this.groupBox2.Controls.Add(this.AgeLabel);
            this.groupBox2.Controls.Add(this.WeightLabel);
            this.groupBox2.Controls.Add(this.HeightLabel);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(292, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 555);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мой профиль";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(64, 188);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 21);
            this.HeightBox.TabIndex = 14;
            // 
            // caloryButton
            // 
            this.caloryButton.BackColor = System.Drawing.Color.Lime;
            this.caloryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caloryButton.Location = new System.Drawing.Point(21, 400);
            this.caloryButton.Name = "caloryButton";
            this.caloryButton.Size = new System.Drawing.Size(97, 28);
            this.caloryButton.TabIndex = 9;
            this.caloryButton.Text = "Рассчитать";
            this.caloryButton.UseVisualStyleBackColor = false;
            this.caloryButton.Click += new System.EventHandler(this.caloryButton_Click);
            // 
            // CaloryCounterBox
            // 
            this.CaloryCounterBox.Enabled = false;
            this.CaloryCounterBox.Location = new System.Drawing.Point(124, 405);
            this.CaloryCounterBox.Name = "CaloryCounterBox";
            this.CaloryCounterBox.Size = new System.Drawing.Size(100, 21);
            this.CaloryCounterBox.TabIndex = 11;
            // 
            // WeightBox
            // 
            this.WeightBox.Location = new System.Drawing.Point(64, 135);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(100, 21);
            this.WeightBox.TabIndex = 13;
            // 
            // CaloryLabel
            // 
            this.CaloryLabel.AutoSize = true;
            this.CaloryLabel.Location = new System.Drawing.Point(53, 367);
            this.CaloryLabel.Name = "CaloryLabel";
            this.CaloryLabel.Size = new System.Drawing.Size(128, 15);
            this.CaloryLabel.TabIndex = 10;
            this.CaloryLabel.Text = "Дневная норма калорий";
            this.CaloryLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(64, 88);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 21);
            this.AgeBox.TabIndex = 12;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(64, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 21);
            this.NameBox.TabIndex = 11;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(26, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(27, 15);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 88);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(47, 15);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Возраст";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(12, 138);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(38, 15);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "Вес, кг";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(4, 191);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightLabel.TabIndex = 10;
            this.HeightLabel.Text = "Рост, см";
            // 
            // DailyRationLabel
            // 
            this.DailyRationLabel.AutoSize = true;
            this.DailyRationLabel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DailyRationLabel.Location = new System.Drawing.Point(662, 6);
            this.DailyRationLabel.Name = "DailyRationLabel";
            this.DailyRationLabel.Size = new System.Drawing.Size(110, 15);
            this.DailyRationLabel.TabIndex = 7;
            this.DailyRationLabel.Text = "Мой дневной рацион";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "menu.png");
            this.imageList1.Images.SetKeyName(1, "cocktail.png");
            this.imageList1.Images.SetKeyName(2, "porridge.png");
            this.imageList1.Images.SetKeyName(3, "mushrooms.png");
            this.imageList1.Images.SetKeyName(4, "flour.png");
            this.imageList1.Images.SetKeyName(5, "salami.png");
            this.imageList1.Images.SetKeyName(6, "compote.png");
            this.imageList1.Images.SetKeyName(7, "butter.png");
            this.imageList1.Images.SetKeyName(8, "milk.png");
            this.imageList1.Images.SetKeyName(9, "breakfast.png");
            this.imageList1.Images.SetKeyName(10, "bread.png");
            this.imageList1.Images.SetKeyName(11, "meat.png");
            this.imageList1.Images.SetKeyName(12, "vegetables.png");
            this.imageList1.Images.SetKeyName(13, "nuts.png");
            this.imageList1.Images.SetKeyName(14, "lunch.png");
            this.imageList1.Images.SetKeyName(15, "fish.png");
            this.imageList1.Images.SetKeyName(16, "cupcake.png");
            this.imageList1.Images.SetKeyName(17, "juice.png");
            this.imageList1.Images.SetKeyName(18, "soup.png");
            this.imageList1.Images.SetKeyName(19, "dried-fruit.png");
            this.imageList1.Images.SetKeyName(20, "cheese.png");
            this.imageList1.Images.SetKeyName(21, "muesli.png");
            this.imageList1.Images.SetKeyName(22, "fruits.png");
            this.imageList1.Images.SetKeyName(23, "cheese1.png");
            this.imageList1.Images.SetKeyName(24, "berry.png");
            this.imageList1.Images.SetKeyName(25, "eggs.png");
            this.imageList1.Images.SetKeyName(26, "check.png");
            this.imageList1.Images.SetKeyName(27, "search.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Webp.net-resizeimage.jpg");
            this.imageList2.Images.SetKeyName(1, "Webp.net-resizeimage (1).jpg");
            this.imageList2.Images.SetKeyName(2, "dinner2.png");
            this.imageList2.Images.SetKeyName(3, "check.png");
            this.imageList2.Images.SetKeyName(4, "search.png");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.caloriesBox);
            this.groupBox3.Controls.Add(this.gramsBox);
            this.groupBox3.Controls.Add(this.carbsBox);
            this.groupBox3.Controls.Add(this.fatsBox);
            this.groupBox3.Controls.Add(this.proteinBox);
            this.groupBox3.Controls.Add(this.caloriesLabel);
            this.groupBox3.Controls.Add(this.gramsLabel);
            this.groupBox3.Controls.Add(this.carbsLabel);
            this.groupBox3.Controls.Add(this.fatsLabel);
            this.groupBox3.Controls.Add(this.proteinLabel);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(723, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 225);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Продукт не выбран";
            // 
            // caloriesBox
            // 
            this.caloriesBox.Enabled = false;
            this.caloriesBox.Location = new System.Drawing.Point(74, 163);
            this.caloriesBox.Name = "caloriesBox";
            this.caloriesBox.Size = new System.Drawing.Size(100, 21);
            this.caloriesBox.TabIndex = 9;
            // 
            // gramsBox
            // 
            this.gramsBox.Enabled = false;
            this.gramsBox.Location = new System.Drawing.Point(74, 138);
            this.gramsBox.Name = "gramsBox";
            this.gramsBox.Size = new System.Drawing.Size(100, 21);
            this.gramsBox.TabIndex = 8;
            // 
            // carbsBox
            // 
            this.carbsBox.Enabled = false;
            this.carbsBox.Location = new System.Drawing.Point(74, 113);
            this.carbsBox.Name = "carbsBox";
            this.carbsBox.Size = new System.Drawing.Size(100, 21);
            this.carbsBox.TabIndex = 7;
            // 
            // fatsBox
            // 
            this.fatsBox.Enabled = false;
            this.fatsBox.Location = new System.Drawing.Point(74, 87);
            this.fatsBox.Name = "fatsBox";
            this.fatsBox.Size = new System.Drawing.Size(100, 21);
            this.fatsBox.TabIndex = 6;
            // 
            // proteinBox
            // 
            this.proteinBox.Enabled = false;
            this.proteinBox.Location = new System.Drawing.Point(74, 60);
            this.proteinBox.Name = "proteinBox";
            this.proteinBox.Size = new System.Drawing.Size(100, 21);
            this.proteinBox.TabIndex = 5;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(20, 166);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(49, 15);
            this.caloriesLabel.TabIndex = 4;
            this.caloriesLabel.Text = "Калории";
            // 
            // gramsLabel
            // 
            this.gramsLabel.AutoSize = true;
            this.gramsLabel.Location = new System.Drawing.Point(36, 141);
            this.gramsLabel.Name = "gramsLabel";
            this.gramsLabel.Size = new System.Drawing.Size(32, 15);
            this.gramsLabel.TabIndex = 3;
            this.gramsLabel.Text = "Вес, г";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(19, 113);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(56, 15);
            this.carbsLabel.TabIndex = 2;
            this.carbsLabel.Text = "Углеводы";
            // 
            // fatsLabel
            // 
            this.fatsLabel.AutoSize = true;
            this.fatsLabel.Location = new System.Drawing.Point(32, 87);
            this.fatsLabel.Name = "fatsLabel";
            this.fatsLabel.Size = new System.Drawing.Size(36, 15);
            this.fatsLabel.TabIndex = 1;
            this.fatsLabel.Text = "Жиры";
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(32, 60);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(37, 15);
            this.proteinLabel.TabIndex = 0;
            this.proteinLabel.Text = "Белки";
            // 
            // gramsTrackBar
            // 
            this.gramsTrackBar.Location = new System.Drawing.Point(624, 297);
            this.gramsTrackBar.Maximum = 1000;
            this.gramsTrackBar.Minimum = 1;
            this.gramsTrackBar.Name = "gramsTrackBar";
            this.gramsTrackBar.Size = new System.Drawing.Size(200, 45);
            this.gramsTrackBar.TabIndex = 14;
            this.gramsTrackBar.TabStop = false;
            this.gramsTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gramsTrackBar.Value = 100;
            this.gramsTrackBar.Scroll += new System.EventHandler(this.gramsTrackBar_Scroll);
            this.gramsTrackBar.Move += new System.EventHandler(this.gramsTrackBar_Move);
            // 
            // RationCaloriesLabel
            // 
            this.RationCaloriesLabel.AutoSize = true;
            this.RationCaloriesLabel.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RationCaloriesLabel.Location = new System.Drawing.Point(583, 345);
            this.RationCaloriesLabel.Name = "RationCaloriesLabel";
            this.RationCaloriesLabel.Size = new System.Drawing.Size(164, 15);
            this.RationCaloriesLabel.TabIndex = 15;
            this.RationCaloriesLabel.Text = "Калорийность данного рациона";
            // 
            // RationCaloriesBox
            // 
            this.RationCaloriesBox.Enabled = false;
            this.RationCaloriesBox.Location = new System.Drawing.Point(762, 344);
            this.RationCaloriesBox.Name = "RationCaloriesBox";
            this.RationCaloriesBox.Size = new System.Drawing.Size(100, 20);
            this.RationCaloriesBox.TabIndex = 16;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Location = new System.Drawing.Point(235, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(31, 20);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(537, 268);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 17;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddMealTimeButton
            // 
            this.AddMealTimeButton.Location = new System.Drawing.Point(642, 268);
            this.AddMealTimeButton.Name = "AddMealTimeButton";
            this.AddMealTimeButton.Size = new System.Drawing.Size(75, 23);
            this.AddMealTimeButton.TabIndex = 18;
            this.AddMealTimeButton.Text = "Добавить";
            this.AddMealTimeButton.UseVisualStyleBackColor = true;
            this.AddMealTimeButton.Click += new System.EventHandler(this.AddMealTimeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SpringGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Location = new System.Drawing.Point(75, 486);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 40);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Версия для печати";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeButton.Location = new System.Drawing.Point(75, 443);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 20;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(941, 572);
            this.Controls.Add(this.AddMealTimeButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RationCaloriesBox);
            this.Controls.Add(this.RationCaloriesLabel);
            this.Controls.Add(this.gramsTrackBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DailyRationLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.treeView1);
            this.Name = "Meal";
            this.Text = "Your Daily Ration";
            this.Load += new System.EventHandler(this.Meal_Load);
            this.Menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gramsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lowActivity;
        private System.Windows.Forms.RadioButton normalActivity;
        private System.Windows.Forms.RadioButton middleActivity;
        private System.Windows.Forms.RadioButton highActivity;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WeightBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label DailyRationLabel;
        private System.Windows.Forms.Button caloryButton;
        private System.Windows.Forms.Label CaloryLabel;
        private System.Windows.Forms.TextBox CaloryCounterBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label gramsLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label fatsLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.TextBox caloriesBox;
        private System.Windows.Forms.TextBox gramsBox;
        private System.Windows.Forms.TextBox carbsBox;
        private System.Windows.Forms.TextBox fatsBox;
        private System.Windows.Forms.TextBox proteinBox;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.TrackBar gramsTrackBar;
        private System.Windows.Forms.Label RationCaloriesLabel;
        private System.Windows.Forms.TextBox RationCaloriesBox;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddMealTimeButton;
        public System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button ChangeButton;
    }
}

