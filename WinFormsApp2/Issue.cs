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
    public partial class Issue : Form
    {
        public Issue()
        {
            InitializeComponent();
        }

        private void IBBtn_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            librarian.Show();
            this.Close();
        }

        private void Issuebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully issued the book !", " Issue book", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
