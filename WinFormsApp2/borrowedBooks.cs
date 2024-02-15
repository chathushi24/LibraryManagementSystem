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
    public partial class borrowedBooks : Form
    {
        DataTable datatable = new DataTable();
        Member member;
        public borrowedBooks(Member member)
        {
            InitializeComponent();
            this.member = member;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrowedBooks_Load(object sender, EventArgs e)
        {
            List<Book> borrowedBooks = new List<Book>();
            borrowedBooks = member.BorrowedBooks;

            datatable.Columns.Add("ID");
            datatable.Columns.Add("ISBN");
            datatable.Columns.Add("Author");
            datatable.Columns.Add("Title");
            datatable.Columns.Add("Published_Year");

            if (borrowedBooks.Count > 0)
            {
                foreach (Book book in borrowedBooks)
                {
                    datatable.Rows.Add(book.Id, book.ISBN, book.Author, book.Title, book.Publishedyear);
                }
            }

            dataGridView1.DataSource = datatable;
        }
    }
}