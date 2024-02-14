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
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Librarian librarian = new Librarian();
            //librarian.Show();
            this.Close();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void UMbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfuly Updated the member", "Updated Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
