namespace WinFormsApp2
{
    partial class Removebook
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
            button1 = new Button();
            RBbookid = new TextBox();
            RBisbn = new TextBox();
            RBbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 545);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 323);
            label1.Name = "label1";
            label1.Size = new Size(205, 38);
            label1.TabIndex = 1;
            label1.Text = "Remove Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.remove;
            pictureBox1.Location = new Point(92, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 203);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Book Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(463, 271);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "ISBN No :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(789, 489);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RBbookid
            // 
            RBbookid.Location = new Point(579, 200);
            RBbookid.Name = "RBbookid";
            RBbookid.Size = new Size(171, 31);
            RBbookid.TabIndex = 4;
            // 
            // RBisbn
            // 
            RBisbn.Location = new Point(579, 271);
            RBisbn.Name = "RBisbn";
            RBisbn.Size = new Size(171, 31);
            RBisbn.TabIndex = 5;
            // 
            // RBbtn
            // 
            RBbtn.BackColor = SystemColors.HotTrack;
            RBbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBbtn.Location = new Point(645, 491);
            RBbtn.Name = "RBbtn";
            RBbtn.Size = new Size(112, 34);
            RBbtn.TabIndex = 6;
            RBbtn.Text = "Done ";
            RBbtn.UseVisualStyleBackColor = false;
            RBbtn.Click += removebtn_Click;
            // 
            // Removebook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 544);
            Controls.Add(RBbtn);
            Controls.Add(RBisbn);
            Controls.Add(RBbookid);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Removebook";
            Text = "Removebook";
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
        private Button button1;
        private TextBox RBbookid;
        private TextBox RBisbn;
        private Button RBbtn;
    }
}