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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AMbackBtn_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            librarian.Show();
            this.Close();
        }

        private void AMbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added the member!","Added Member", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
