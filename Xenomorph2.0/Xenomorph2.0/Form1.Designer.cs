namespace Xenomorph2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxFraction = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWar = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.textBoxFractionLore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.groupBoxLIstFraction = new System.Windows.Forms.GroupBox();
            this.buttonUpdateList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.созданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormOfLifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLIstFraction.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFraction
            // 
            this.listBoxFraction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFraction.BackColor = System.Drawing.Color.Black;
            this.listBoxFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFraction.ForeColor = System.Drawing.Color.White;
            this.listBoxFraction.FormattingEnabled = true;
            this.listBoxFraction.ItemHeight = 20;
            this.listBoxFraction.Location = new System.Drawing.Point(6, 41);
            this.listBoxFraction.Name = "listBoxFraction";
            this.listBoxFraction.Size = new System.Drawing.Size(317, 404);
            this.listBoxFraction.TabIndex = 0;
            this.listBoxFraction.Click += new System.EventHandler(this.listBoxFraction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список фракций";
            // 
            // buttonWar
            // 
            this.buttonWar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWar.Location = new System.Drawing.Point(6, 467);
            this.buttonWar.Name = "buttonWar";
            this.buttonWar.Size = new System.Drawing.Size(100, 25);
            this.buttonWar.TabIndex = 4;
            this.buttonWar.Text = "Атака";
            this.buttonWar.UseVisualStyleBackColor = true;
            this.buttonWar.Click += new System.EventHandler(this.buttonWar_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Location = new System.Drawing.Point(854, 467);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(100, 25);
            this.buttonSkip.TabIndex = 5;
            this.buttonSkip.Text = "Завершить ход";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // textBoxFractionLore
            // 
            this.textBoxFractionLore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFractionLore.BackColor = System.Drawing.Color.Black;
            this.textBoxFractionLore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFractionLore.ForeColor = System.Drawing.Color.White;
            this.textBoxFractionLore.Location = new System.Drawing.Point(341, 41);
            this.textBoxFractionLore.Multiline = true;
            this.textBoxFractionLore.Name = "textBoxFractionLore";
            this.textBoxFractionLore.ReadOnly = true;
            this.textBoxFractionLore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFractionLore.Size = new System.Drawing.Size(613, 405);
            this.textBoxFractionLore.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Информация о фракции";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ход";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStep.BackColor = System.Drawing.Color.Black;
            this.textBoxStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStep.ForeColor = System.Drawing.Color.White;
            this.textBoxStep.Location = new System.Drawing.Point(789, 467);
            this.textBoxStep.Multiline = true;
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.ReadOnly = true;
            this.textBoxStep.Size = new System.Drawing.Size(50, 25);
            this.textBoxStep.TabIndex = 13;
            this.textBoxStep.Text = "0";
            // 
            // groupBoxLIstFraction
            // 
            this.groupBoxLIstFraction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLIstFraction.BackColor = System.Drawing.Color.Black;
            this.groupBoxLIstFraction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxLIstFraction.BackgroundImage")));
            this.groupBoxLIstFraction.Controls.Add(this.buttonUpdateList);
            this.groupBoxLIstFraction.Controls.Add(this.textBoxStep);
            this.groupBoxLIstFraction.Controls.Add(this.label4);
            this.groupBoxLIstFraction.Controls.Add(this.label3);
            this.groupBoxLIstFraction.Controls.Add(this.textBoxFractionLore);
            this.groupBoxLIstFraction.Controls.Add(this.buttonSkip);
            this.groupBoxLIstFraction.Controls.Add(this.buttonWar);
            this.groupBoxLIstFraction.Controls.Add(this.label1);
            this.groupBoxLIstFraction.Controls.Add(this.listBoxFraction);
            this.groupBoxLIstFraction.Location = new System.Drawing.Point(12, 51);
            this.groupBoxLIstFraction.Name = "groupBoxLIstFraction";
            this.groupBoxLIstFraction.Size = new System.Drawing.Size(960, 498);
            this.groupBoxLIstFraction.TabIndex = 2;
            this.groupBoxLIstFraction.TabStop = false;
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateList.Location = new System.Drawing.Point(112, 467);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Size = new System.Drawing.Size(120, 25);
            this.buttonUpdateList.TabIndex = 14;
            this.buttonUpdateList.Text = "Обновить списки";
            this.buttonUpdateList.UseVisualStyleBackColor = true;
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеToolStripMenuItem,
            this.lvlUpToolStripMenuItem,
            this.LoreToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // созданиеToolStripMenuItem
            // 
            this.созданиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormOfLifeToolStripMenuItem});
            this.созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
            this.созданиеToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.созданиеToolStripMenuItem.Text = "Создание";
            // 
            // FormOfLifeToolStripMenuItem
            // 
            this.FormOfLifeToolStripMenuItem.Name = "FormOfLifeToolStripMenuItem";
            this.FormOfLifeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.FormOfLifeToolStripMenuItem.Text = "Форма жизни";
            this.FormOfLifeToolStripMenuItem.Click += new System.EventHandler(this.FormOfLifeToolStripMenuItem_Click);
            // 
            // lvlUpToolStripMenuItem
            // 
            this.lvlUpToolStripMenuItem.Name = "lvlUpToolStripMenuItem";
            this.lvlUpToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.lvlUpToolStripMenuItem.Text = "Прокачка";
            this.lvlUpToolStripMenuItem.Click += new System.EventHandler(this.lvlUpToolStripMenuItem_Click);
            // 
            // LoreToolStripMenuItem
            // 
            this.LoreToolStripMenuItem.Name = "LoreToolStripMenuItem";
            this.LoreToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.LoreToolStripMenuItem.Text = "Лор";
            this.LoreToolStripMenuItem.Click += new System.EventHandler(this.LoreToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBoxLIstFraction);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Игра ксеноморфы";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.groupBoxLIstFraction.ResumeLayout(false);
            this.groupBoxLIstFraction.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonWar;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.TextBox textBoxFractionLore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.GroupBox groupBoxLIstFraction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormOfLifeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lvlUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button buttonUpdateList;
    }
}

