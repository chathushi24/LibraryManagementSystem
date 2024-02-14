namespace WinFormsApp2
{
    partial class Return
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
            isbn = new Label();
            label4 = new Label();
            memID = new TextBox();
            bookISBN = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
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
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 312);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 181);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "Return Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources._return;
            pictureBox1.Location = new Point(71, 80);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 1;
            label2.Text = "Member Id :";
            // 
            // isbn
            // 
            isbn.AutoSize = true;
            isbn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isbn.Location = new Point(292, 109);
            isbn.Margin = new Padding(2, 0, 2, 0);
            isbn.Name = "isbn";
            isbn.Size = new Size(82, 19);
            isbn.TabIndex = 2;
            isbn.Text = "Book ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 155);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 3;
            label4.Text = "Return Date :";
            // 
            // memID
            // 
            memID.Location = new Point(398, 68);
            memID.Margin = new Padding(2);
            memID.Name = "memID";
            memID.Size = new Size(169, 23);
            memID.TabIndex = 4;
            // 
            // bookISBN
            // 
            bookISBN.Location = new Point(398, 109);
            bookISBN.Margin = new Padding(2);
            bookISBN.Name = "bookISBN";
            bookISBN.Size = new Size(169, 23);
            bookISBN.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(398, 155);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(508, 262);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RBbtn
            // 
            RBbtn.BackColor = SystemColors.HotTrack;
            RBbtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RBbtn.Location = new Point(407, 262);
            RBbtn.Margin = new Padding(2);
            RBbtn.Name = "RBbtn";
            RBbtn.Size = new Size(78, 20);
            RBbtn.TabIndex = 8;
            RBbtn.Text = "Done";
            RBbtn.UseVisualStyleBackColor = false;
            RBbtn.Click += RBbtn_Click;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 310);
            Controls.Add(RBbtn);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(bookISBN);
            Controls.Add(memID);
            Controls.Add(label4);
            Controls.Add(isbn);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Return";
            Text = "Return";
            Load += Return_Load;
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
        private Label isbn;
        private Label label4;
        private TextBox memID;
        private TextBox bookISBN;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button RBbtn;
    }
}