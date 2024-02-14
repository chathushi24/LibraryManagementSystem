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
    public partial class AddBook : Form
    {
        Admin librarian;
        Library library;
        public AddBook(Admin librarian, Library library)
        {
            InitializeComponent();
            this.button1.Visible = true;
            this.librarian = librarian;
            this.library = library;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Librarian librarian = new Librarian();
            //librarian.Show();
            this.Close();
        }

        private void ABbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Addbookid.Text.Trim();
                string author = ABauthor.Text.Trim();
                string title = ABtitle.Text.Trim();
                string isbn = ABisbn.Text.Trim();
                bool availability = true;
                int publishedYr = ABdate.Value.Year;

                if (AByes.Checked)
                {
                    availability = true;
                }
                else
                {
                    availability = false;
                }

                Book book = new Book(id, author, title, isbn, publishedYr);
                library.addNewBook(book);

                Addbookid.Clear();
                ABauthor.Clear();
                ABtitle.Clear();
                ABisbn.Clear();
            }
            catch
            {
                MessageBox.Show("Successfully added the book !", "Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
