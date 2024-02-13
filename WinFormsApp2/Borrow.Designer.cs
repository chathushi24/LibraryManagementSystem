namespace WinFormsApp2
{
    partial class Borrow
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
            Bmember = new Label();
            Bbookid = new Label();
            Bdate = new Label();
            Bback = new Button();
            BorrowM = new TextBox();
            borrowbid = new TextBox();
            borrowdate = new DateTimePicker();
            BBbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 523);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 305);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 1;
            label1.Text = "Borrow Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.book__2_;
            pictureBox1.Location = new Point(91, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Bmember
            // 
            Bmember.AutoSize = true;
            Bmember.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bmember.Location = new Point(392, 115);
            Bmember.Name = "Bmember";
            Bmember.Size = new Size(124, 28);
            Bmember.TabIndex = 1;
            Bmember.Text = "Member Id :";
            // 
            // Bbookid
            // 
            Bbookid.AutoSize = true;
            Bbookid.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bbookid.Location = new Point(392, 182);
            Bbookid.Name = "Bbookid";
            Bbookid.Size = new Size(94, 28);
            Bbookid.TabIndex = 2;
            Bbookid.Text = "Book Id :";
            // 
            // Bdate
            // 
            Bdate.AutoSize = true;
            Bdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bdate.Location = new Point(392, 245);
            Bdate.Name = "Bdate";
            Bdate.Size = new Size(136, 28);
            Bdate.TabIndex = 3;
            Bdate.Text = "Borrow Date :";
            // 
            // Bback
            // 
            Bback.BackColor = SystemColors.GradientActiveCaption;
            Bback.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bback.Location = new Point(712, 460);
            Bback.Name = "Bback";
            Bback.Size = new Size(112, 34);
            Bback.TabIndex = 4;
            Bback.Text = "Back ";
            Bback.UseVisualStyleBackColor = false;
            Bback.Click += Bback_Click;
            // 
            // BorrowM
            // 
            BorrowM.Location = new Point(543, 112);
            BorrowM.Name = "BorrowM";
            BorrowM.Size = new Size(249, 31);
            BorrowM.TabIndex = 5;
            // 
            // borrowbid
            // 
            borrowbid.Location = new Point(543, 182);
            borrowbid.Name = "borrowbid";
            borrowbid.Size = new Size(249, 31);
            borrowbid.TabIndex = 6;
            // 
            // borrowdate
            // 
            borrowdate.Location = new Point(543, 247);
            borrowdate.Name = "borrowdate";
            borrowdate.Size = new Size(249, 31);
            borrowdate.TabIndex = 7;
            // 
            // BBbtn
            // 
            BBbtn.BackColor = SystemColors.HotTrack;
            BBbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BBbtn.Location = new Point(566, 460);
            BBbtn.Name = "BBbtn";
            BBbtn.Size = new Size(112, 34);
            BBbtn.TabIndex = 8;
            BBbtn.Text = "Done";
            BBbtn.UseVisualStyleBackColor = false;
            BBbtn.Click += BBbtn_Click;
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 523);
            Controls.Add(BBbtn);
            Controls.Add(borrowdate);
            Controls.Add(borrowbid);
            Controls.Add(BorrowM);
            Controls.Add(Bback);
            Controls.Add(Bdate);
            Controls.Add(Bbookid);
            Controls.Add(Bmember);
            Controls.Add(panel1);
            Name = "Borrow";
            Text = "Borrow";
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
        private Label Bmember;
        private Label Bbookid;
        private Label Bdate;
        private Button Bback;
        private TextBox BorrowM;
        private TextBox borrowbid;
        private DateTimePicker borrowdate;
        private Button BBbtn;
    }
}