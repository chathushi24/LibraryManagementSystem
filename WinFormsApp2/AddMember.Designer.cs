namespace WinFormsApp2
{
    partial class AddMember
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
            label6 = new Label();
            firstname = new TextBox();
            lastname = new TextBox();
            AMusername = new TextBox();
            password = new TextBox();
            AMmemid = new TextBox();
            AMbackBtn = new Button();
            AMbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 544);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 321);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 1;
            label1.Text = "Add Members";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.add_group;
            pictureBox1.Location = new Point(87, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 103);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 154);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(400, 218);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 3;
            label4.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(400, 276);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 4;
            label5.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(400, 329);
            label6.Name = "label6";
            label6.Size = new Size(124, 28);
            label6.TabIndex = 5;
            label6.Text = "Member Id :";
            // 
            // firstname
            // 
            firstname.Location = new Point(543, 103);
            firstname.Name = "firstname";
            firstname.Size = new Size(253, 31);
            firstname.TabIndex = 6;
            // 
            // lastname
            // 
            lastname.Location = new Point(543, 154);
            lastname.Name = "lastname";
            lastname.Size = new Size(253, 31);
            lastname.TabIndex = 7;
            // 
            // AMusername
            // 
            AMusername.Location = new Point(543, 215);
            AMusername.Name = "AMusername";
            AMusername.Size = new Size(253, 31);
            AMusername.TabIndex = 8;
            // 
            // password
            // 
            password.Location = new Point(543, 276);
            password.Name = "password";
            password.Size = new Size(253, 31);
            password.TabIndex = 9;
            // 
            // AMmemid
            // 
            AMmemid.Location = new Point(543, 329);
            AMmemid.Name = "AMmemid";
            AMmemid.Size = new Size(253, 31);
            AMmemid.TabIndex = 10;
            // 
            // AMbackBtn
            // 
            AMbackBtn.BackColor = SystemColors.GradientActiveCaption;
            AMbackBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AMbackBtn.Location = new Point(779, 471);
            AMbackBtn.Name = "AMbackBtn";
            AMbackBtn.Size = new Size(112, 34);
            AMbackBtn.TabIndex = 11;
            AMbackBtn.Text = "Back";
            AMbackBtn.UseVisualStyleBackColor = false;
            AMbackBtn.Click += AMbackBtn_Click;
            // 
            // AMbtn
            // 
            AMbtn.BackColor = SystemColors.HotTrack;
            AMbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AMbtn.Location = new Point(642, 471);
            AMbtn.Name = "AMbtn";
            AMbtn.Size = new Size(112, 34);
            AMbtn.TabIndex = 12;
            AMbtn.Text = "Done";
            AMbtn.UseVisualStyleBackColor = false;
            AMbtn.Click += AMbtn_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 542);
            Controls.Add(AMbtn);
            Controls.Add(AMbackBtn);
            Controls.Add(AMmemid);
            Controls.Add(password);
            Controls.Add(AMusername);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AddMember";
            Text = "AddMember";
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
        private Label label5;
        private Label label6;
        private TextBox firstname;
        private TextBox lastname;
        private TextBox AMusername;
        private TextBox password;
        private TextBox AMmemid;
        private Button AMbackBtn;
        private Button AMbtn;
    }
}