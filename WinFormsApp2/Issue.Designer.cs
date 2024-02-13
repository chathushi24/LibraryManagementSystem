namespace WinFormsApp2
{
    partial class Issue
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            IBmemid = new TextBox();
            IBbookid = new TextBox();
            IBisbn = new TextBox();
            IBBtn = new Button();
            Issuebtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 522);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 320);
            label1.Name = "label1";
            label1.Size = new Size(166, 38);
            label1.TabIndex = 1;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.icons8_book_50;
            pictureBox1.Location = new Point(89, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(412, 109);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 1;
            label2.Text = "Member Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(412, 183);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Book Id :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(412, 257);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 3;
            label4.Text = "ISBN No :";
            // 
            // IBmemid
            // 
            IBmemid.Location = new Point(564, 110);
            IBmemid.Name = "IBmemid";
            IBmemid.Size = new Size(168, 31);
            IBmemid.TabIndex = 4;
            // 
            // IBbookid
            // 
            IBbookid.Location = new Point(564, 183);
            IBbookid.Name = "IBbookid";
            IBbookid.Size = new Size(168, 31);
            IBbookid.TabIndex = 5;
            // 
            // IBisbn
            // 
            IBisbn.Location = new Point(564, 254);
            IBisbn.Name = "IBisbn";
            IBisbn.Size = new Size(168, 31);
            IBisbn.TabIndex = 6;
            // 
            // IBBtn
            // 
            IBBtn.BackColor = SystemColors.GradientActiveCaption;
            IBBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBBtn.Location = new Point(738, 447);
            IBBtn.Name = "IBBtn";
            IBBtn.Size = new Size(112, 34);
            IBBtn.TabIndex = 7;
            IBBtn.Text = "Back";
            IBBtn.UseVisualStyleBackColor = false;
            IBBtn.Click += IBBtn_Click;
            // 
            // Issuebtn
            // 
            Issuebtn.BackColor = SystemColors.HotTrack;
            Issuebtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Issuebtn.Location = new Point(604, 450);
            Issuebtn.Name = "Issuebtn";
            Issuebtn.Size = new Size(112, 34);
            Issuebtn.TabIndex = 8;
            Issuebtn.Text = "Done";
            Issuebtn.UseVisualStyleBackColor = false;
            Issuebtn.Click += Issuebtn_Click;
            // 
            // Issue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 520);
            Controls.Add(Issuebtn);
            Controls.Add(IBBtn);
            Controls.Add(IBisbn);
            Controls.Add(IBbookid);
            Controls.Add(IBmemid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Issue";
            Text = "Issue";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox IBmemid;
        private TextBox IBbookid;
        private TextBox IBisbn;
        private Button IBBtn;
        private Button Issuebtn;
    }
}