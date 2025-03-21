namespace Xenomorph2._0
{
    partial class FormLore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLore));
            this.comboBoxCommander = new System.Windows.Forms.ComboBox();
            this.textBoxWarLore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCommander
            // 
            this.comboBoxCommander.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCommander.BackColor = System.Drawing.Color.Black;
            this.comboBoxCommander.ForeColor = System.Drawing.Color.White;
            this.comboBoxCommander.FormattingEnabled = true;
            this.comboBoxCommander.Items.AddRange(new object[] {
            "Фракции",
            "Формы жизни",
            "Гены",
            "Планеты",
            "Космический флот"});
            this.comboBoxCommander.Location = new System.Drawing.Point(63, 6);
            this.comboBoxCommander.Name = "comboBoxCommander";
            this.comboBoxCommander.Size = new System.Drawing.Size(210, 21);
            this.comboBoxCommander.TabIndex = 16;
            this.comboBoxCommander.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommander_SelectedIndexChanged);
            this.comboBoxCommander.DropDownClosed += new System.EventHandler(this.comboBoxCommander_DropDownClosed);
            // 
            // textBoxWarLore
            // 
            this.textBoxWarLore.AcceptsReturn = true;
            this.textBoxWarLore.AcceptsTab = true;
            this.textBoxWarLore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWarLore.BackColor = System.Drawing.Color.Black;
            this.textBoxWarLore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarLore.ForeColor = System.Drawing.Color.White;
            this.textBoxWarLore.Location = new System.Drawing.Point(12, 33);
            this.textBoxWarLore.Multiline = true;
            this.textBoxWarLore.Name = "textBoxWarLore";
            this.textBoxWarLore.ReadOnly = true;
            this.textBoxWarLore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWarLore.Size = new System.Drawing.Size(261, 167);
            this.textBoxWarLore.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "обьект:";
            // 
            // FormLore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWarLore);
            this.Controls.Add(this.comboBoxCommander);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "FormLore";
            this.Text = "Чтение лора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCommander;
        private System.Windows.Forms.TextBox textBoxWarLore;
        private System.Windows.Forms.Label label3;
    }
}