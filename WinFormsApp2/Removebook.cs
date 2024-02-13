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
        public Removebook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            librarian.Show();
            this.Close();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully removed the book","Removed book",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
