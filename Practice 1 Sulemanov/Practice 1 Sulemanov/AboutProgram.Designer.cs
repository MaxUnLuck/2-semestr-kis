namespace Practice_1_Sulemanov
{
    partial class AboutProgramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramForm));
            label1 = new Label();
            Info = new GroupBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(245, 15);
            label1.TabIndex = 0;
            label1.Text = "Создана програма Максимом Сулейманов";
            // 
            // Info
            // 
            Info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Info.BackColor = SystemColors.GradientActiveCaption;
            Info.Controls.Add(linkLabel1);
            Info.Controls.Add(label2);
            Info.Controls.Add(label1);
            Info.Location = new Point(12, 27);
            Info.Name = "Info";
            Info.Size = new Size(259, 148);
            Info.TabIndex = 1;
            Info.TabStop = false;
            Info.Tag = "яйцехлет";
            Info.Text = "Информация";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(74, 119);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ссылка на автора";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(8, 70);
            label2.Name = "label2";
            label2.Size = new Size(206, 15);
            label2.TabIndex = 1;
            label2.Text = "Сделано по заданию предмета КИС.";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 168);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AboutProgramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(282, 361);
            Controls.Add(pictureBox1);
            Controls.Add(Info);
            MaximumSize = new Size(298, 600);
            MinimumSize = new Size(298, 400);
            Name = "AboutProgramForm";
            Text = "AboutProgram";
            Load += AboutProgram_Load;
            Info.ResumeLayout(false);
            Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox Info;
        private LinkLabel linkLabel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}