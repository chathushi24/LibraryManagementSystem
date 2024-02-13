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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void LogoutLBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void AddbookBtn_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Close();
        }

        private void RemovebookBtn_Click(object sender, EventArgs e)
        {
            Removebook removebook = new Removebook();
            removebook.Show();
            this.Close();

        }

        private void AddmemberBtn_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Close();
        }

        private void RemoveMBtn_Click(object sender, EventArgs e)
        {
            RemoveMember removeMember = new RemoveMember();
            removeMember.Show();
            this.Close();
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.Show();
            this.Close();
        }

        private void updateMBtn_Click(object sender, EventArgs e)
        {
            UpdateMember updateMember = new UpdateMember();
            updateMember.Show();
            this.Close();
        }

        private void Transactionbtn_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Close();
        }
    }
}