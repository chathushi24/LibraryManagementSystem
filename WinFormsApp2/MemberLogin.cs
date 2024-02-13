﻿using System;
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
        public MemberLogin()
        {
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
            search search = new search();
            search.Show();
            this.Close();
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            Borrow borrow = new Borrow();
            borrow.Show();
            this.Close();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Return returnbook = new Return();
            returnbook.Show();
            this.Close();
        }
    }
}