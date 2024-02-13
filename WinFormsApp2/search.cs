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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            memberLogin.Show();
            this.Close();
        }

        private void SBbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
