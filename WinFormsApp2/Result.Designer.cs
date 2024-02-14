namespace WinFormsApp2
{
    partial class Result
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
            hheading = new Label();
            isbn = new TextBox();
            author = new TextBox();
            title = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            availability = new TextBox();
            label1 = new Label();
            publishedYear = new TextBox();
            SuspendLayout();
            // 
            // hheading
            // 
            hheading.AutoSize = true;
            hheading.BackColor = SystemColors.Control;
            hheading.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hheading.Location = new Point(268, 47);
            hheading.Margin = new Padding(2, 0, 2, 0);
            hheading.Name = "hheading";
            hheading.Size = new Size(100, 20);
            hheading.TabIndex = 9;
            hheading.Text = "Search Result";
            // 
            // isbn
            // 
            isbn.Location = new Point(264, 234);
            isbn.Margin = new Padding(2);
            isbn.Name = "isbn";
            isbn.Size = new Size(212, 23);
            isbn.TabIndex = 16;
            // 
            // author
            // 
            author.Location = new Point(264, 190);
            author.Margin = new Padding(2);
            author.Name = "author";
            author.Size = new Size(212, 23);
            author.TabIndex = 15;
            // 
            // title
            // 
            title.Location = new Point(264, 150);
            title.Margin = new Padding(2);
            title.Name = "title";
            title.Size = new Size(212, 23);
            title.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 272);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 13;
            label5.Text = "Published date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 230);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "ISBN: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(170, 189);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 11;
            label3.Text = "Author :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 147);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "Title: ";
            // 
            // availability
            // 
            availability.Location = new Point(276, 316);
            availability.Margin = new Padding(2);
            availability.Name = "availability";
            availability.Size = new Size(200, 23);
            availability.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 315);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 18;
            label1.Text = "Availability: ";
            // 
            // publishedYear
            // 
            publishedYear.Location = new Point(303, 272);
            publishedYear.Margin = new Padding(2);
            publishedYear.Name = "publishedYear";
            publishedYear.Size = new Size(174, 23);
            publishedYear.TabIndex = 22;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 479);
            Controls.Add(publishedYear);
            Controls.Add(availability);
            Controls.Add(label1);
            Controls.Add(isbn);
            Controls.Add(author);
            Controls.Add(title);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(hheading);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Result";
            Text = "Result";
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label hheading;
        private TextBox isbn;
        private TextBox author;
        private TextBox title;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox availability;
        private Label label1;
        private TextBox publishedYear;
    }
}