﻿using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Return : Form
    {
        User user;
        public Return(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void RBbtn_Click(object sender, EventArgs e)
        {
            List<Book> books = libraryDatabase.getAllBookRecords();
            Member member;

            // Remove additional white space and get input from text boxes
            string memID = this.memID.Text.Trim();
            string isbn = this.bookISBN.Text.Trim();

            // initialize book results
            Book bookResultByISBN;

            // Find book results
            bookResultByISBN = books.Find(book => book.ISBN == isbn);

            // Find member
            member = libraryDatabase.getRecord<User>("Id", memID, "Users") as Member;

            if (member != null)
            {
                // if book by isbn is not null issue book
                if (bookResultByISBN != null)
                {
                    user.returnBook(bookResultByISBN, member);
                }
                // If book not found show message
                else
                {
                    MessageBox.Show("Book not found", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Member not found", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
