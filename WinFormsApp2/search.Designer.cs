namespace WinFormsApp2
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            isbnLable = new Label();
            title = new TextBox();
            isbn = new TextBox();
            backBtn = new Button();
            SBbtn = new Button();
            id = new TextBox();
            lable = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 352);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 194);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Search Books ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 109);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 133);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Title: ";
            // 
            // isbnLable
            // 
            isbnLable.AutoSize = true;
            isbnLable.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isbnLable.Location = new Point(292, 203);
            isbnLable.Margin = new Padding(2, 0, 2, 0);
            isbnLable.Name = "isbnLable";
            isbnLable.Size = new Size(50, 20);
            isbnLable.TabIndex = 3;
            isbnLable.Text = "ISBN :";
            // 
            // title
            // 
            title.Location = new Point(387, 131);
            title.Margin = new Padding(2);
            title.Name = "title";
            title.Size = new Size(212, 23);
            title.TabIndex = 5;
            // 
            // isbn
            // 
            isbn.Location = new Point(387, 202);
            isbn.Margin = new Padding(2);
            isbn.Name = "isbn";
            isbn.Size = new Size(212, 23);
            isbn.TabIndex = 7;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.GradientActiveCaption;
            backBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(571, 302);
            backBtn.Margin = new Padding(2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(79, 20);
            backBtn.TabIndex = 9;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SBbtn
            // 
            SBbtn.BackColor = SystemColors.HotTrack;
            SBbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SBbtn.Location = new Point(463, 302);
            SBbtn.Margin = new Padding(2);
            SBbtn.Name = "SBbtn";
            SBbtn.Size = new Size(79, 20);
            SBbtn.TabIndex = 10;
            SBbtn.Text = "Search";
            SBbtn.UseVisualStyleBackColor = false;
            SBbtn.Click += SBbtn_Click;
            // 
            // id
            // 
            id.Location = new Point(387, 166);
            id.Margin = new Padding(2);
            id.Name = "id";
            id.Size = new Size(212, 23);
            id.TabIndex = 12;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable.Location = new Point(292, 168);
            lable.Margin = new Padding(2, 0, 2, 0);
            lable.Name = "lable";
            lable.Size = new Size(32, 20);
            lable.TabIndex = 11;
            lable.Text = "ID: ";
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 350);
            Controls.Add(id);
            Controls.Add(lable);
            Controls.Add(SBbtn);
            Controls.Add(backBtn);
            Controls.Add(isbn);
            Controls.Add(title);
            Controls.Add(isbnLable);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "search";
            Text = "search";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label isbnLable;
        private TextBox title;
        private TextBox isbn;
        private Button backBtn;
        private Button SBbtn;
        private TextBox id;
        private Label lable;
    }
}