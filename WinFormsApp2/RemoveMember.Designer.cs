namespace WinFormsApp2
{
    partial class RemoveMember
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
            RMmemid = new TextBox();
            RMusername = new TextBox();
            RMpassword = new TextBox();
            button1 = new Button();
            RMbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 499);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 295);
            label1.Name = "label1";
            label1.Size = new Size(235, 38);
            label1.TabIndex = 1;
            label1.Text = "Remove Member";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.remove__1_;
            pictureBox1.Location = new Point(83, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(413, 143);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 1;
            label2.Text = "Member Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(413, 205);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 2;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(413, 265);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // RMmemid
            // 
            RMmemid.Location = new Point(553, 146);
            RMmemid.Name = "RMmemid";
            RMmemid.Size = new Size(203, 31);
            RMmemid.TabIndex = 4;
            // 
            // RMusername
            // 
            RMusername.Location = new Point(554, 205);
            RMusername.Name = "RMusername";
            RMusername.Size = new Size(202, 31);
            RMusername.TabIndex = 5;
            // 
            // RMpassword
            // 
            RMpassword.Location = new Point(557, 271);
            RMpassword.Name = "RMpassword";
            RMpassword.Size = new Size(199, 31);
            RMpassword.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(705, 436);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RMbtn
            // 
            RMbtn.BackColor = SystemColors.HotTrack;
            RMbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RMbtn.Location = new Point(557, 436);
            RMbtn.Name = "RMbtn";
            RMbtn.Size = new Size(112, 34);
            RMbtn.TabIndex = 8;
            RMbtn.Text = "Done";
            RMbtn.UseVisualStyleBackColor = false;
            RMbtn.Click += RMbtn_Click;
            // 
            // RemoveMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 500);
            Controls.Add(RMbtn);
            Controls.Add(button1);
            Controls.Add(RMpassword);
            Controls.Add(RMusername);
            Controls.Add(RMmemid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RemoveMember";
            Text = "RemoveMember";
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
        private TextBox RMmemid;
        private TextBox RMusername;
        private TextBox RMpassword;
        private Button button1;
        private Button RMbtn;
    }
}