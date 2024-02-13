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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Sname = new TextBox();
            Sauthor = new TextBox();
            Stitle = new TextBox();
            Sdate = new DateTimePicker();
            backBtn = new Button();
            SBbtn = new Button();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 586);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 323);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 1;
            label1.Text = "Search Books ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(417, 128);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(417, 198);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 2;
            label3.Text = "Author :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(417, 266);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 3;
            label4.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(417, 335);
            label5.Name = "label5";
            label5.Size = new Size(172, 30);
            label5.TabIndex = 4;
            label5.Text = "Published date :";
            // 
            // Sname
            // 
            Sname.Location = new Point(553, 132);
            Sname.Name = "Sname";
            Sname.Size = new Size(301, 31);
            Sname.TabIndex = 5;
            // 
            // Sauthor
            // 
            Sauthor.Location = new Point(553, 200);
            Sauthor.Name = "Sauthor";
            Sauthor.Size = new Size(301, 31);
            Sauthor.TabIndex = 6;
            // 
            // Stitle
            // 
            Stitle.Location = new Point(553, 272);
            Stitle.Name = "Stitle";
            Stitle.Size = new Size(301, 31);
            Stitle.TabIndex = 7;
            // 
            // Sdate
            // 
            Sdate.Location = new Point(608, 335);
            Sdate.Name = "Sdate";
            Sdate.Size = new Size(300, 31);
            Sdate.TabIndex = 8;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.GradientActiveCaption;
            backBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(816, 504);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(112, 34);
            backBtn.TabIndex = 9;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SBbtn
            // 
            SBbtn.BackColor = SystemColors.HotTrack;
            SBbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SBbtn.Location = new Point(661, 504);
            SBbtn.Name = "SBbtn";
            SBbtn.Size = new Size(112, 34);
            SBbtn.TabIndex = 10;
            SBbtn.Text = "Done";
            SBbtn.UseVisualStyleBackColor = false;
            SBbtn.Click += SBbtn_Click;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 582);
            Controls.Add(SBbtn);
            Controls.Add(backBtn);
            Controls.Add(Sdate);
            Controls.Add(Stitle);
            Controls.Add(Sauthor);
            Controls.Add(Sname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Sname;
        private TextBox Sauthor;
        private TextBox Stitle;
        private DateTimePicker Sdate;
        private Button backBtn;
        private Button SBbtn;
    }
}