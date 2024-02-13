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
        public AddBook()
        {
            InitializeComponent();
            this.button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            librarian.Show();
            this.Close();
        }

        private void ABbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added the book !", "Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
