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
    public partial class MemberLogin : Form
    {
        Member member;
        Library library;

        public MemberLogin(Member member, Library library)
        {
            this.member = member;
            this.library = library;
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            search Search = new search(library.getAllBooks());
            Search.ShowDialog();
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            Issue borrow = new Issue(member);
            borrow.Show();
            this.Close();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Return returnbook = new Return(member);
            returnbook.Show();
            this.Close();
        }
    }
}
