namespace WinFormsApp2
{
    partial class UpdateMember
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
            label5 = new Label();
            UMfirst = new TextBox();
            UMlast = new TextBox();
            UMusername = new TextBox();
            UMpassword = new TextBox();
            button1 = new Button();
            UMbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 538);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 310);
            label1.Name = "label1";
            label1.Size = new Size(227, 38);
            label1.TabIndex = 1;
            label1.Text = "Update Member";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.icons8_update_64;
            pictureBox1.Location = new Point(94, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 115);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(409, 184);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(409, 254);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 3;
            label4.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(409, 316);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 4;
            label5.Text = "Password :";
            // 
            // UMfirst
            // 
            UMfirst.Location = new Point(563, 118);
            UMfirst.Name = "UMfirst";
            UMfirst.Size = new Size(239, 31);
            UMfirst.TabIndex = 5;
            // 
            // UMlast
            // 
            UMlast.Location = new Point(563, 184);
            UMlast.Name = "UMlast";
            UMlast.Size = new Size(239, 31);
            UMlast.TabIndex = 6;
            // 
            // UMusername
            // 
            UMusername.Location = new Point(563, 251);
            UMusername.Name = "UMusername";
            UMusername.Size = new Size(239, 31);
            UMusername.TabIndex = 7;
            // 
            // UMpassword
            // 
            UMpassword.Location = new Point(563, 316);
            UMpassword.Name = "UMpassword";
            UMpassword.Size = new Size(239, 31);
            UMpassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(745, 478);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UMbtn
            // 
            UMbtn.BackColor = SystemColors.HotTrack;
            UMbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UMbtn.Location = new Point(605, 479);
            UMbtn.Name = "UMbtn";
            UMbtn.Size = new Size(112, 34);
            UMbtn.TabIndex = 10;
            UMbtn.Text = "Done";
            UMbtn.UseVisualStyleBackColor = false;
            UMbtn.Click += UMbtn_Click;
            // 
            // UpdateMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 538);
            Controls.Add(UMbtn);
            Controls.Add(button1);
            Controls.Add(UMpassword);
            Controls.Add(UMusername);
            Controls.Add(UMlast);
            Controls.Add(UMfirst);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "UpdateMember";
            Text = "UpdateMember";
            Load += UpdateMember_Load;
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
        private TextBox UMfirst;
        private TextBox UMlast;
        private TextBox UMusername;
        private TextBox UMpassword;
        private Button button1;
        private Button UMbtn;
    }
}