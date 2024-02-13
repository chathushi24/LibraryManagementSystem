namespace WinFormsApp2
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            LoginBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 546);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 366);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 2;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 321);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 1;
            label1.Text = "Library Management ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(476, 175);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 1;
            label3.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(597, 172);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(217, 31);
            txtUsername.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(476, 244);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(601, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(213, 31);
            txtPassword.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.HotTrack;
            LoginBtn.Location = new Point(683, 331);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(119, 39);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += loginBtn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 544);
            Controls.Add(LoginBtn);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPassword;
        private Button LoginBtn;
    }
}
