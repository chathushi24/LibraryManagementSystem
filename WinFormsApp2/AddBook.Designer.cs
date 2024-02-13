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
            label7 = new Label();
            label8 = new Label();
            Addbookid = new TextBox();
            ABauthor = new TextBox();
            ABtitle = new TextBox();
            ABisbn = new TextBox();
            AByes = new CheckBox();
            ABno = new CheckBox();
            copies = new TextBox();
            ABdate = new DateTimePicker();
            button1 = new Button();
            ABbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 525);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 306);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 1;
            label1.Text = "Add Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.add1;
            pictureBox1.Location = new Point(103, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(413, 54);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Book Id :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(413, 107);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 2;
            label3.Text = "Author :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(413, 163);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 3;
            label4.Text = "Title :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(413, 218);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 4;
            label5.Text = "ISBN No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(413, 272);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 5;
            label6.Text = "Availabilty :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(413, 332);
            label7.Name = "label7";
            label7.Size = new Size(187, 28);
            label7.TabIndex = 6;
            label7.Text = "Number of copies :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(413, 391);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 7;
            label8.Text = "Published year :";
            // 
            // Addbookid
            // 
            Addbookid.Location = new Point(543, 59);
            Addbookid.Name = "Addbookid";
            Addbookid.Size = new Size(296, 31);
            Addbookid.TabIndex = 8;
            // 
            // ABauthor
            // 
            ABauthor.Location = new Point(543, 107);
            ABauthor.Name = "ABauthor";
            ABauthor.Size = new Size(296, 31);
            ABauthor.TabIndex = 9;
            // 
            // ABtitle
            // 
            ABtitle.Location = new Point(543, 163);
            ABtitle.Name = "ABtitle";
            ABtitle.Size = new Size(296, 31);
            ABtitle.TabIndex = 10;
            // 
            // ABisbn
            // 
            ABisbn.Location = new Point(543, 218);
            ABisbn.Name = "ABisbn";
            ABisbn.Size = new Size(296, 31);
            ABisbn.TabIndex = 11;
            // 
            // AByes
            // 
            AByes.AutoSize = true;
            AByes.Location = new Point(543, 274);
            AByes.Name = "AByes";
            AByes.Size = new Size(63, 29);
            AByes.TabIndex = 12;
            AByes.Text = "Yes";
            AByes.UseVisualStyleBackColor = true;
            // 
            // ABno
            // 
            ABno.AutoSize = true;
            ABno.Location = new Point(641, 274);
            ABno.Name = "ABno";
            ABno.Size = new Size(62, 29);
            ABno.TabIndex = 13;
            ABno.Text = "No";
            ABno.UseVisualStyleBackColor = true;
            // 
            // copies
            // 
            copies.Location = new Point(617, 338);
            copies.Name = "copies";
            copies.Size = new Size(222, 31);
            copies.TabIndex = 14;
            // 
            // ABdate
            // 
            ABdate.Location = new Point(576, 391);
            ABdate.Name = "ABdate";
            ABdate.Size = new Size(278, 31);
            ABdate.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(765, 469);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ABbtn
            // 
            ABbtn.BackColor = SystemColors.HotTrack;
            ABbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ABbtn.Location = new Point(627, 469);
            ABbtn.Name = "ABbtn";
            ABbtn.Size = new Size(112, 34);
            ABbtn.TabIndex = 17;
            ABbtn.Text = "Done";
            ABbtn.UseVisualStyleBackColor = false;
            ABbtn.Click += ABbtn_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 526);
            Controls.Add(ABbtn);
            Controls.Add(button1);
            Controls.Add(ABdate);
            Controls.Add(copies);
            Controls.Add(ABno);
            Controls.Add(AByes);
            Controls.Add(ABisbn);
            Controls.Add(ABtitle);
            Controls.Add(ABauthor);
            Controls.Add(Addbookid);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
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
        private Label label7;
        private Label label8;
        private TextBox Addbookid;
        private TextBox ABauthor;
        private TextBox ABtitle;
        private TextBox ABisbn;
        private CheckBox AByes;
        private CheckBox ABno;
        private TextBox copies;
        private DateTimePicker ABdate;
        private Button button1;
        private Button ABbtn;
    }
}