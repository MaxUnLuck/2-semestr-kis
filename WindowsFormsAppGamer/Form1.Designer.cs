namespace WindowsFormsAppGamer
{
    partial class FormMain
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
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDestrictionary = new System.Windows.Forms.Label();
            this.textBoxDestrictionary = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDelete = new System.Windows.Forms.Label();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxInventaryOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShopOutput = new System.Windows.Forms.TextBox();
            this.Shop = new System.Windows.Forms.Label();
            this.groupBoxBuy = new System.Windows.Forms.GroupBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelBuy = new System.Windows.Forms.Label();
            this.textBoxBuy = new System.Windows.Forms.TextBox();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxCreate.Controls.Add(this.buttonClear);
            this.groupBoxCreate.Controls.Add(this.buttonCreate);
            this.groupBoxCreate.Controls.Add(this.comboBoxCategory);
            this.groupBoxCreate.Controls.Add(this.labelCategory);
            this.groupBoxCreate.Controls.Add(this.labelDestrictionary);
            this.groupBoxCreate.Controls.Add(this.textBoxDestrictionary);
            this.groupBoxCreate.Controls.Add(this.labelName);
            this.groupBoxCreate.Controls.Add(this.textBoxName);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 283);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(223, 155);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Создание предмета";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 125);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Стереть";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(142, 125);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(117, 100);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(6, 103);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "Категория";
            // 
            // labelDestrictionary
            // 
            this.labelDestrictionary.AutoSize = true;
            this.labelDestrictionary.Location = new System.Drawing.Point(6, 45);
            this.labelDestrictionary.Name = "labelDestrictionary";
            this.labelDestrictionary.Size = new System.Drawing.Size(55, 13);
            this.labelDestrictionary.TabIndex = 3;
            this.labelDestrictionary.Text = "описание";
            // 
            // textBoxDestrictionary
            // 
            this.textBoxDestrictionary.Location = new System.Drawing.Point(117, 42);
            this.textBoxDestrictionary.Multiline = true;
            this.textBoxDestrictionary.Name = "textBoxDestrictionary";
            this.textBoxDestrictionary.Size = new System.Drawing.Size(100, 52);
            this.textBoxDestrictionary.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Controls.Add(this.labelDelete);
            this.groupBoxDelete.Controls.Add(this.textBoxDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(241, 283);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(223, 155);
            this.groupBoxDelete.TabIndex = 8;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Удаление предмета";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(142, 125);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(6, 19);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(57, 13);
            this.labelDelete.TabIndex = 1;
            this.labelDelete.Text = "Название";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(117, 16);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelete.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(470, 283);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(223, 155);
            this.groupBoxSearch.TabIndex = 9;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Найти предмета";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(142, 125);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(117, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // textBoxInventaryOutput
            // 
            this.textBoxInventaryOutput.AcceptsReturn = true;
            this.textBoxInventaryOutput.AcceptsTab = true;
            this.textBoxInventaryOutput.AllowDrop = true;
            this.textBoxInventaryOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxInventaryOutput.Location = new System.Drawing.Point(12, 60);
            this.textBoxInventaryOutput.Multiline = true;
            this.textBoxInventaryOutput.Name = "textBoxInventaryOutput";
            this.textBoxInventaryOutput.ReadOnly = true;
            this.textBoxInventaryOutput.Size = new System.Drawing.Size(452, 217);
            this.textBoxInventaryOutput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Инвентарь";
            // 
            // textBoxShopOutput
            // 
            this.textBoxShopOutput.AcceptsReturn = true;
            this.textBoxShopOutput.AcceptsTab = true;
            this.textBoxShopOutput.AllowDrop = true;
            this.textBoxShopOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShopOutput.Location = new System.Drawing.Point(470, 60);
            this.textBoxShopOutput.Multiline = true;
            this.textBoxShopOutput.Name = "textBoxShopOutput";
            this.textBoxShopOutput.ReadOnly = true;
            this.textBoxShopOutput.Size = new System.Drawing.Size(452, 217);
            this.textBoxShopOutput.TabIndex = 13;
            // 
            // Shop
            // 
            this.Shop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Shop.AutoSize = true;
            this.Shop.Location = new System.Drawing.Point(883, 35);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(39, 13);
            this.Shop.TabIndex = 14;
            this.Shop.Text = "Лавка";
            // 
            // groupBoxBuy
            // 
            this.groupBoxBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxBuy.Controls.Add(this.buttonBuy);
            this.groupBoxBuy.Controls.Add(this.labelBuy);
            this.groupBoxBuy.Controls.Add(this.textBoxBuy);
            this.groupBoxBuy.Location = new System.Drawing.Point(699, 283);
            this.groupBoxBuy.Name = "groupBoxBuy";
            this.groupBoxBuy.Size = new System.Drawing.Size(223, 155);
            this.groupBoxBuy.TabIndex = 10;
            this.groupBoxBuy.TabStop = false;
            this.groupBoxBuy.Text = "Купить предмет";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(142, 125);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 6;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelBuy
            // 
            this.labelBuy.AutoSize = true;
            this.labelBuy.Location = new System.Drawing.Point(6, 19);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(57, 13);
            this.labelBuy.TabIndex = 1;
            this.labelBuy.Text = "Название";
            // 
            // textBoxBuy
            // 
            this.textBoxBuy.Location = new System.Drawing.Point(117, 16);
            this.textBoxBuy.Name = "textBoxBuy";
            this.textBoxBuy.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuy.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 472);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxBuy);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.textBoxShopOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxInventaryOutput);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(947, 488);
            this.Name = "FormMain";
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxBuy.ResumeLayout(false);
            this.groupBoxBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDestrictionary;
        private System.Windows.Forms.TextBox textBoxDestrictionary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxInventaryOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShopOutput;
        private System.Windows.Forms.Label Shop;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxBuy;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelBuy;
        private System.Windows.Forms.TextBox textBoxBuy;
    }
}

