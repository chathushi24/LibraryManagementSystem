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
        Admin librarian;
        public AddMember(Admin librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void AMbackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AMbtn_Click(object sender, EventArgs e)
        {
            // Get text values
            string id = this.AMmemid.Text.Trim();
            string fname = this.lastname.Text.Trim();
            string lname = this.firstname.Text.Trim();
            string uname = this.AMusername.Text.Trim();
            string password = this.password.Text.Trim();

            // Create member object
            Member member = new Member(id,fname, lname, uname, password);

            // Call Librarian call method to delete member
            librarian.addNewMember(member);

            // Clear texts
            this.AMmemid.Clear();
            this.lastname.Clear();
            this.firstname.Clear();
            this.AMusername.Clear();
            this.password.Clear();

        }
    }
}
