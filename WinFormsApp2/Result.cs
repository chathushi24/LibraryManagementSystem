using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Result : Form
    {
        Book book;
        public Result(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            // When the form is loaded fill text boxes with the result book
            this.title.Text = book.Title;
            this.author.Text = book.Author;
            this.isbn.Text = book.ISBN;
            // Convert int to string
            this.publishedYear.Text = book.Publishedyear.ToString();
            // Convert bool to string
            this.availability.Text = book.Availability.ToString();
        }
    }
}
