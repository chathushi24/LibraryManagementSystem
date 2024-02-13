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
        public Return()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            memberLogin.Show();
            this.Close();

        }

        private void RBbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
