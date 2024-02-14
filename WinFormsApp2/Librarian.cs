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
    public partial class Librarian : Form
    {
        Admin librarian;
        Library library;
        public Librarian(Admin librarian, Library library)
        {
            this.librarian = librarian;
            this.library = library;
            InitializeComponent();
        }

        private void LogoutLBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void AddbookBtn_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(librarian, library);
            addBook.ShowDialog();
        }

        private void RemovebookBtn_Click(object sender, EventArgs e)
        {
            Removebook removebook = new Removebook(library);
            removebook.ShowDialog();

        }

        private void AddmemberBtn_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember(librarian);
            addMember.ShowDialog();
        }

        private void RemoveMBtn_Click(object sender, EventArgs e)
        {
            RemoveMember removeMember = new RemoveMember(librarian);
            removeMember.ShowDialog();
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue(librarian);
            issue.ShowDialog();
        }

        private void returnBBtn_Click(object sender, EventArgs e)
        {

        }

        private void Transactionbtn_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(librarian);
            transactions.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            search Search = new search(library.getAllBooks());
            Search.ShowDialog();
        }


    }
}
