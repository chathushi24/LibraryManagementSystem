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
    public partial class RemoveMember : Form
    {
        Admin librarian;

        public RemoveMember(Admin librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Librarian librarian = new Librarian();
            //librarian.Show();
            this.Close();
        }

        private void RMbtn_Click(object sender, EventArgs e)
        {

            string username = RMusername.Text;
            string password = RMpassword.Text;
            string id = RMmemid.Text;


            // Get the member from database using member id
            Member member = libraryDatabase.getRecord<User>("Id", id.Trim(), "Users") as Member;

            // Check whether the member is found
            if (member != null)
            {
                // Check whether the member's username and password is correct
                if (member.userlogin(username, password))
                {
                    librarian.removeMember(member.Id);
                }
                else
                {
                    MessageBox.Show("", "Removed Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Member not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
