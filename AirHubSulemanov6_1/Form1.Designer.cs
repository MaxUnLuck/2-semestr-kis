namespace AirHubSulemanov6_1
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
            this.textBoxListOut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountOfLines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameOfHub = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountHour = new System.Windows.Forms.TextBox();
            this.buttonCloseHub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNextPlane = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxListOut
            // 
            this.textBoxListOut.AcceptsReturn = true;
            this.textBoxListOut.AcceptsTab = true;
            this.textBoxListOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListOut.Location = new System.Drawing.Point(6, 19);
            this.textBoxListOut.Multiline = true;
            this.textBoxListOut.Name = "textBoxListOut";
            this.textBoxListOut.ReadOnly = true;
            this.textBoxListOut.Size = new System.Drawing.Size(441, 189);
            this.textBoxListOut.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxListOut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 214);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список самолетов на полосах";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxCountOfLines);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNameOfHub);
            this.groupBox2.Controls.Add(this.buttonCreate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "количество полос";
            // 
            // textBoxCountOfLines
            // 
            this.textBoxCountOfLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountOfLines.Location = new System.Drawing.Point(167, 49);
            this.textBoxCountOfLines.Name = "textBoxCountOfLines";
            this.textBoxCountOfLines.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountOfLines.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "название авиахаба";
            // 
            // textBoxNameOfHub
            // 
            this.textBoxNameOfHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameOfHub.Location = new System.Drawing.Point(167, 24);
            this.textBoxNameOfHub.Name = "textBoxNameOfHub";
            this.textBoxNameOfHub.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameOfHub.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCreate.Location = new System.Drawing.Point(167, 119);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxCountHour);
            this.groupBox3.Controls.Add(this.buttonCloseHub);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.buttonNextPlane);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(290, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 148);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время";
            // 
            // textBoxCountHour
            // 
            this.textBoxCountHour.AcceptsReturn = true;
            this.textBoxCountHour.AcceptsTab = true;
            this.textBoxCountHour.Location = new System.Drawing.Point(88, 77);
            this.textBoxCountHour.Name = "textBoxCountHour";
            this.textBoxCountHour.ReadOnly = true;
            this.textBoxCountHour.Size = new System.Drawing.Size(80, 22);
            this.textBoxCountHour.TabIndex = 2;
            // 
            // buttonCloseHub
            // 
            this.buttonCloseHub.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCloseHub.Location = new System.Drawing.Point(6, 119);
            this.buttonCloseHub.Name = "buttonCloseHub";
            this.buttonCloseHub.Size = new System.Drawing.Size(162, 23);
            this.buttonCloseHub.TabIndex = 7;
            this.buttonCloseHub.Text = "Закрыть авиа хаб";
            this.buttonCloseHub.UseVisualStyleBackColor = false;
            this.buttonCloseHub.Click += new System.EventHandler(this.buttonCloseHub_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(6, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Задержка вылета";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonNextPlane
            // 
            this.buttonNextPlane.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonNextPlane.Location = new System.Drawing.Point(6, 24);
            this.buttonNextPlane.Name = "buttonNextPlane";
            this.buttonNextPlane.Size = new System.Drawing.Size(162, 23);
            this.buttonNextPlane.TabIndex = 5;
            this.buttonNextPlane.Text = "Обновить список";
            this.buttonNextPlane.UseVisualStyleBackColor = false;
            this.buttonNextPlane.Click += new System.EventHandler(this.buttonNextPlane_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProgramToolStripMenuItem
            // 
            this.ProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem";
            this.ProgramToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ProgramToolStripMenuItem.Text = "Программа";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть программу";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(492, 453);
            this.Name = "FormMain";
            this.Text = "Авиа хаб";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxListOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountOfLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameOfHub;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCloseHub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNextPlane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountHour;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
    }
}

