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
    public partial class search : Form
    {
        List<Book> books;
        public search(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBbtn_Click(object sender, EventArgs e)
        {
            // Remove additional white space and get input from text boxes
            string title = this.title.Text.Trim();
            string isbn = this.isbn.Text.Trim();
            string id = this.id.Text.Trim();
            
            // initialize book results
            Book bookResultByTitle;
            Book bookResultByISBN;
            Book bookResultById;

            // Initialize result form
            Result result;

            // Find book results
            bookResultByTitle = books.Find(book => book.Title == title);
            bookResultByISBN = books.Find(book => book.ISBN == isbn);
            bookResultById = books.Find(book => book.Id == id);

            // if book by title is not null show result
            if (bookResultByTitle != null)
            {
                result = new Result(bookResultByTitle);
                result.ShowDialog();
            }
            // if book by isbn is not null show result
            else if (bookResultByISBN != null)
            {
                result = new Result(bookResultByISBN);
                result.ShowDialog();
            }
            // if book by id is not null show result
            else if (bookResultById != null)
            {
                result = new Result(bookResultById);
                result.ShowDialog();
            }
            // If book not found show message
            else
            {
                MessageBox.Show("Book not found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
