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
            headerText = new Label();
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
            panel1.Controls.Add(headerText);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 313);
            panel1.TabIndex = 0;
            // 
            // headerText
            // 
            headerText.AutoSize = true;
            headerText.BackColor = SystemColors.Control;
            headerText.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerText.Location = new Point(50, 192);
            headerText.Margin = new Padding(2, 0, 2, 0);
            headerText.Name = "headerText";
            headerText.Size = new Size(111, 25);
            headerText.TabIndex = 1;
            headerText.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.icons8_book_50;
            pictureBox1.Location = new Point(62, 91);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Member Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 2;
            label3.Text = "Book Id :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(288, 154);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 3;
            label4.Text = "ISBN No :";
            // 
            // IBmemid
            // 
            IBmemid.Location = new Point(395, 66);
            IBmemid.Margin = new Padding(2);
            IBmemid.Name = "IBmemid";
            IBmemid.Size = new Size(119, 23);
            IBmemid.TabIndex = 4;
            // 
            // IBbookid
            // 
            IBbookid.Location = new Point(395, 110);
            IBbookid.Margin = new Padding(2);
            IBbookid.Name = "IBbookid";
            IBbookid.Size = new Size(119, 23);
            IBbookid.TabIndex = 5;
            // 
            // IBisbn
            // 
            IBisbn.Location = new Point(395, 152);
            IBisbn.Margin = new Padding(2);
            IBisbn.Name = "IBisbn";
            IBisbn.Size = new Size(119, 23);
            IBisbn.TabIndex = 6;
            // 
            // IBBtn
            // 
            IBBtn.BackColor = SystemColors.GradientActiveCaption;
            IBBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBBtn.Location = new Point(517, 268);
            IBBtn.Margin = new Padding(2);
            IBBtn.Name = "IBBtn";
            IBBtn.Size = new Size(78, 20);
            IBBtn.TabIndex = 7;
            IBBtn.Text = "Back";
            IBBtn.UseVisualStyleBackColor = false;
            IBBtn.Click += IBBtn_Click;
            // 
            // Issuebtn
            // 
            Issuebtn.BackColor = SystemColors.HotTrack;
            Issuebtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Issuebtn.Location = new Point(423, 270);
            Issuebtn.Margin = new Padding(2);
            Issuebtn.Name = "Issuebtn";
            Issuebtn.Size = new Size(78, 20);
            Issuebtn.TabIndex = 8;
            Issuebtn.Text = "Done";
            Issuebtn.UseVisualStyleBackColor = false;
            Issuebtn.Click += Issuebtn_Click;
            // 
            // Issue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 312);
            Controls.Add(Issuebtn);
            Controls.Add(IBBtn);
            Controls.Add(IBisbn);
            Controls.Add(IBbookid);
            Controls.Add(IBmemid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Issue";
            Text = "Issue";
            Load += Issue_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label headerText;
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