namespace WinFormsApp2
{
    partial class AddBook
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
            label8 = new Label();
            ABauthor = new TextBox();
            ABtitle = new TextBox();
            ABisbn = new TextBox();
            AByes = new CheckBox();
            ABdate = new DateTimePicker();
            button1 = new Button();
            ABbtn = new Button();
            Addbookid = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 315);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 184);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.add1;
            pictureBox1.Location = new Point(72, 90);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "Book Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "Author :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(289, 119);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 3;
            label4.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 159);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 4;
            label5.Text = "ISBN No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(289, 194);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 5;
            label6.Text = "Availabilty :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(289, 235);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 19);
            label8.TabIndex = 7;
            label8.Text = "Published year :";
            // 
            // ABauthor
            // 
            ABauthor.Location = new Point(380, 75);
            ABauthor.Margin = new Padding(2, 2, 2, 2);
            ABauthor.Name = "ABauthor";
            ABauthor.Size = new Size(208, 23);
            ABauthor.TabIndex = 9;
            // 
            // ABtitle
            // 
            ABtitle.Location = new Point(380, 115);
            ABtitle.Margin = new Padding(2, 2, 2, 2);
            ABtitle.Name = "ABtitle";
            ABtitle.Size = new Size(208, 23);
            ABtitle.TabIndex = 10;
            // 
            // ABisbn
            // 
            ABisbn.Location = new Point(380, 155);
            ABisbn.Margin = new Padding(2, 2, 2, 2);
            ABisbn.Name = "ABisbn";
            ABisbn.Size = new Size(208, 23);
            ABisbn.TabIndex = 11;
            // 
            // AByes
            // 
            AByes.AutoSize = true;
            AByes.Location = new Point(386, 195);
            AByes.Margin = new Padding(2, 2, 2, 2);
            AByes.Name = "AByes";
            AByes.Size = new Size(43, 19);
            AByes.TabIndex = 12;
            AByes.Text = "Yes";
            AByes.UseVisualStyleBackColor = true;
            // 
            // ABdate
            // 
            ABdate.Format = DateTimePickerFormat.Short;
            ABdate.Location = new Point(403, 231);
            ABdate.Margin = new Padding(2, 2, 2, 2);
            ABdate.Name = "ABdate";
            ABdate.Size = new Size(196, 23);
            ABdate.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(536, 281);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ABbtn
            // 
            ABbtn.BackColor = SystemColors.HotTrack;
            ABbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ABbtn.Location = new Point(439, 281);
            ABbtn.Margin = new Padding(2, 2, 2, 2);
            ABbtn.Name = "ABbtn";
            ABbtn.Size = new Size(78, 20);
            ABbtn.TabIndex = 17;
            ABbtn.Text = "Done";
            ABbtn.UseVisualStyleBackColor = false;
            ABbtn.Click += ABbtn_Click;
            // 
            // Addbookid
            // 
            Addbookid.Location = new Point(380, 35);
            Addbookid.Margin = new Padding(2, 2, 2, 2);
            Addbookid.Name = "Addbookid";
            Addbookid.Size = new Size(208, 23);
            Addbookid.TabIndex = 8;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 316);
            Controls.Add(ABbtn);
            Controls.Add(button1);
            Controls.Add(ABdate);
            Controls.Add(AByes);
            Controls.Add(ABisbn);
            Controls.Add(ABtitle);
            Controls.Add(ABauthor);
            Controls.Add(Addbookid);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddBook";
            Text = "AddBook";
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
        private Label label8;
        private TextBox ABauthor;
        private TextBox ABtitle;
        private TextBox ABisbn;
        private CheckBox AByes;
        private DateTimePicker ABdate;
        private Button button1;
        private Button ABbtn;
        private TextBox Addbookid;
    }
}