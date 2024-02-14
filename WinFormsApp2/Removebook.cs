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
    public partial class Removebook : Form
    {
        Library library;

        public Removebook(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Librarian librarian = new Librarian();
            //librarian.Show();
            this.Close();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            // Remove space from the text box input
            string isbn = this.RBisbn.Text.Trim();
            string id = this.RBbookid.Text.Trim();

            // Create book object
            Book book = libraryDatabase.getRecord<Book>("ISBN", isbn, "Books");
            
            // Check whether the book is found
            if (book != null)
            {
                // Match given isbn and id with the book's id and isbn before deleting the book
                if (isbn == book.ISBN && id == book.Id)
                {
                    // call remove book method from library object(Library class's object)
                    library.removeBook(isbn);

                    // Clear test boxes
                    this.RBisbn.Clear();
                    this.RBbookid.Clear();
                }
                else
                {
                    MessageBox.Show("ISBN and ID not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
