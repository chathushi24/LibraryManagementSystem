using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace WinFormsApp2
{
    public partial class Issue : Form
    {
        User user;
        public Issue(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void IBBtn_Click(object sender, EventArgs e)
        {
            //Librarian librarian = new Librarian();
            //librarian.Show();
            this.Close();
        }

        private void Issuebtn_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            Member member;

            // Remove additional white space and get input from text boxes
            string memID = this.IBmemid.Text.Trim();
            string isbn = this.IBisbn.Text.Trim();
            string id = this.IBbookid.Text.Trim();

            // initialize book results
            Book bookResultByISBN;
            Book bookResultById;


            // Find book results
            bookResultByISBN = books.Find(book => book.ISBN == isbn);
            bookResultById = books.Find(book => book.Id == id);

            // Find member
            member = libraryDatabase.getRecord<User>("Id", memID, "Users") as Member;

            if (member != null)
            {
                // if book by isbn is not null issue book
                if (bookResultByISBN != null)
                {
                    user.borrowBook(bookResultByISBN, member);
                    MessageBox.Show("Successfully issued the book !", " Issue book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // if book by id is not null issue book
                else if (bookResultById != null)
                {
                    user.borrowBook(bookResultById, member);
                    MessageBox.Show("Successfully issued the book !", " Issue book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // If book not found show message
                else
                {
                    MessageBox.Show("Book not found", "Issue Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Member not found", "Issue Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
