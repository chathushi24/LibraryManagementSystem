namespace WinFormsApp2
{
    partial class Librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            AddbookBtn = new Button();
            RemovebookBtn = new Button();
            AddmemberBtn = new Button();
            RemoveMBtn = new Button();
            returnBBtn = new Button();
            issueBtn = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            LogoutLBtn = new Button();
            Transactionbtn = new Button();
            searchBtn = new Button();
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
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 32);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO OUR LIBRARY !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.library;
            pictureBox1.Location = new Point(2, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HotTrack;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(352, 25);
            label2.TabIndex = 1;
            label2.Text = "Library Management System - Librarian";
            // 
            // AddbookBtn
            // 
            AddbookBtn.BackColor = SystemColors.HotTrack;
            AddbookBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddbookBtn.Image = Properties.Resources.icons8_add_book_50;
            AddbookBtn.ImageAlign = ContentAlignment.TopCenter;
            AddbookBtn.Location = new Point(78, 184);
            AddbookBtn.Margin = new Padding(2);
            AddbookBtn.Name = "AddbookBtn";
            AddbookBtn.Size = new Size(118, 86);
            AddbookBtn.TabIndex = 2;
            AddbookBtn.Text = "Add Book";
            AddbookBtn.TextAlign = ContentAlignment.BottomCenter;
            AddbookBtn.UseVisualStyleBackColor = false;
            AddbookBtn.Click += AddbookBtn_Click;
            // 
            // RemovebookBtn
            // 
            RemovebookBtn.BackColor = SystemColors.HotTrack;
            RemovebookBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemovebookBtn.Image = (Image)resources.GetObject("RemovebookBtn.Image");
            RemovebookBtn.ImageAlign = ContentAlignment.TopCenter;
            RemovebookBtn.Location = new Point(244, 185);
            RemovebookBtn.Margin = new Padding(2);
            RemovebookBtn.Name = "RemovebookBtn";
            RemovebookBtn.Size = new Size(118, 86);
            RemovebookBtn.TabIndex = 3;
            RemovebookBtn.Text = "Remove Book";
            RemovebookBtn.TextAlign = ContentAlignment.BottomCenter;
            RemovebookBtn.UseVisualStyleBackColor = false;
            RemovebookBtn.Click += RemovebookBtn_Click;
            // 
            // AddmemberBtn
            // 
            AddmemberBtn.BackColor = SystemColors.HotTrack;
            AddmemberBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddmemberBtn.Image = (Image)resources.GetObject("AddmemberBtn.Image");
            AddmemberBtn.ImageAlign = ContentAlignment.TopCenter;
            AddmemberBtn.Location = new Point(418, 184);
            AddmemberBtn.Margin = new Padding(2);
            AddmemberBtn.Name = "AddmemberBtn";
            AddmemberBtn.Size = new Size(118, 86);
            AddmemberBtn.TabIndex = 4;
            AddmemberBtn.Text = "Add Member";
            AddmemberBtn.TextAlign = ContentAlignment.BottomCenter;
            AddmemberBtn.UseVisualStyleBackColor = false;
            AddmemberBtn.Click += AddmemberBtn_Click;
            // 
            // RemoveMBtn
            // 
            RemoveMBtn.BackColor = SystemColors.HotTrack;
            RemoveMBtn.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveMBtn.Image = (Image)resources.GetObject("RemoveMBtn.Image");
            RemoveMBtn.ImageAlign = ContentAlignment.TopCenter;
            RemoveMBtn.Location = new Point(593, 185);
            RemoveMBtn.Margin = new Padding(2);
            RemoveMBtn.Name = "RemoveMBtn";
            RemoveMBtn.Size = new Size(118, 86);
            RemoveMBtn.TabIndex = 5;
            RemoveMBtn.Text = "Remove Member";
            RemoveMBtn.TextAlign = ContentAlignment.BottomCenter;
            RemoveMBtn.UseVisualStyleBackColor = false;
            RemoveMBtn.Click += RemoveMBtn_Click;
            // 
            // returnBBtn
            // 
            returnBBtn.BackColor = SystemColors.HotTrack;
            returnBBtn.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBBtn.Image = (Image)resources.GetObject("returnBBtn.Image");
            returnBBtn.ImageAlign = ContentAlignment.TopCenter;
            returnBBtn.Location = new Point(244, 302);
            returnBBtn.Margin = new Padding(2);
            returnBBtn.Name = "returnBBtn";
            returnBBtn.Size = new Size(118, 86);
            returnBBtn.TabIndex = 6;
            returnBBtn.Text = "Return Book";
            returnBBtn.TextAlign = ContentAlignment.BottomCenter;
            returnBBtn.UseVisualStyleBackColor = false;
            returnBBtn.Click += returnBBtn_Click;
            // 
            // issueBtn
            // 
            issueBtn.BackColor = SystemColors.HotTrack;
            issueBtn.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            issueBtn.Image = (Image)resources.GetObject("issueBtn.Image");
            issueBtn.ImageAlign = ContentAlignment.TopCenter;
            issueBtn.Location = new Point(418, 302);
            issueBtn.Margin = new Padding(2);
            issueBtn.Name = "issueBtn";
            issueBtn.Size = new Size(118, 86);
            issueBtn.TabIndex = 7;
            issueBtn.Text = "Issue Book";
            issueBtn.TextAlign = ContentAlignment.BottomCenter;
            issueBtn.UseVisualStyleBackColor = false;
            issueBtn.Click += issueBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(LogoutLBtn);
            panel2.Location = new Point(-1, 502);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 41);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.GradientActiveCaption;
            pictureBox2.Image = Properties.Resources.logout;
            pictureBox2.Location = new Point(642, 2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // LogoutLBtn
            // 
            LogoutLBtn.BackColor = SystemColors.GradientActiveCaption;
            LogoutLBtn.Location = new Point(674, 2);
            LogoutLBtn.Margin = new Padding(2);
            LogoutLBtn.Name = "LogoutLBtn";
            LogoutLBtn.Size = new Size(90, 27);
            LogoutLBtn.TabIndex = 0;
            LogoutLBtn.Text = "Logout";
            LogoutLBtn.UseVisualStyleBackColor = false;
            LogoutLBtn.Click += LogoutLBtn_Click;
            // 
            // Transactionbtn
            // 
            Transactionbtn.BackColor = SystemColors.HotTrack;
            Transactionbtn.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Transactionbtn.Image = (Image)resources.GetObject("Transactionbtn.Image");
            Transactionbtn.ImageAlign = ContentAlignment.TopCenter;
            Transactionbtn.Location = new Point(593, 302);
            Transactionbtn.Margin = new Padding(2);
            Transactionbtn.Name = "Transactionbtn";
            Transactionbtn.Size = new Size(118, 86);
            Transactionbtn.TabIndex = 9;
            Transactionbtn.Text = "Transactions";
            Transactionbtn.TextAlign = ContentAlignment.BottomCenter;
            Transactionbtn.UseVisualStyleBackColor = false;
            Transactionbtn.Click += Transactionbtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.HotTrack;
            searchBtn.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.TopCenter;
            searchBtn.Location = new Point(78, 302);
            searchBtn.Margin = new Padding(2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(118, 86);
            searchBtn.TabIndex = 10;
            searchBtn.Text = "Search Book";
            searchBtn.TextAlign = ContentAlignment.BottomCenter;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 550);
            Controls.Add(searchBtn);
            Controls.Add(Transactionbtn);
            Controls.Add(panel2);
            Controls.Add(issueBtn);
            Controls.Add(returnBBtn);
            Controls.Add(RemoveMBtn);
            Controls.Add(AddmemberBtn);
            Controls.Add(RemovebookBtn);
            Controls.Add(AddbookBtn);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Librarian";
            Text = "Librarian";
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
        private Button AddbookBtn;
        private Button RemovebookBtn;
        private Button AddmemberBtn;
        private Button RemoveMBtn;
        private Button returnBBtn;
        private Button issueBtn;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button LogoutLBtn;
        private Button Transactionbtn;
        private Button searchBtn;
    }
}