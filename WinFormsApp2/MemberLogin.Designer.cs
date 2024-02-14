namespace WinFormsApp2
{
    partial class MemberLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLogin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            SearchBtn = new Button();
            BorrowBtn = new Button();
            returnBtn = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            LogoutBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 25);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO OUR LIBRARY !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HotTrack;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 64);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(277, 20);
            label2.TabIndex = 1;
            label2.Text = "Library Management System - Member";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.HotTrack;
            SearchBtn.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Image = (Image)resources.GetObject("SearchBtn.Image");
            SearchBtn.ImageAlign = ContentAlignment.TopCenter;
            SearchBtn.Location = new Point(136, 137);
            SearchBtn.Margin = new Padding(2, 2, 2, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(78, 70);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.TextAlign = ContentAlignment.BottomCenter;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // BorrowBtn
            // 
            BorrowBtn.BackColor = SystemColors.HotTrack;
            BorrowBtn.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BorrowBtn.Image = (Image)resources.GetObject("BorrowBtn.Image");
            BorrowBtn.ImageAlign = ContentAlignment.TopCenter;
            BorrowBtn.Location = new Point(295, 137);
            BorrowBtn.Margin = new Padding(2, 2, 2, 2);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(85, 70);
            BorrowBtn.TabIndex = 3;
            BorrowBtn.Text = "Borrow Book";
            BorrowBtn.TextAlign = ContentAlignment.BottomCenter;
            BorrowBtn.UseVisualStyleBackColor = false;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = SystemColors.HotTrack;
            returnBtn.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBtn.Image = (Image)resources.GetObject("returnBtn.Image");
            returnBtn.ImageAlign = ContentAlignment.TopCenter;
            returnBtn.Location = new Point(472, 137);
            returnBtn.Margin = new Padding(2, 2, 2, 2);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(78, 70);
            returnBtn.TabIndex = 4;
            returnBtn.Text = "Return book";
            returnBtn.TextAlign = ContentAlignment.BottomCenter;
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += returnBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(LogoutBtn);
            panel2.Location = new Point(-1, 316);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 34);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.GradientActiveCaption;
            pictureBox2.Image = Properties.Resources.exit;
            pictureBox2.Location = new Point(585, 6);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = SystemColors.GradientActiveCaption;
            LogoutBtn.Location = new Point(612, 6);
            LogoutBtn.Margin = new Padding(2, 2, 2, 2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(78, 20);
            LogoutBtn.TabIndex = 0;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // MemberLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 350);
            Controls.Add(panel2);
            Controls.Add(returnBtn);
            Controls.Add(BorrowBtn);
            Controls.Add(SearchBtn);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MemberLogin";
            Text = "MemberLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button SearchBtn;
        private Button BorrowBtn;
        private Button returnBtn;
        private Panel panel2;
        private Button LogoutBtn;
        private PictureBox pictureBox2;
    }
}