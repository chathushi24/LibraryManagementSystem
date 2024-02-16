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
    public partial class Transactions : Form
    {
        Admin librarian;
        DataTable datatable = new DataTable();

        public Transactions(Admin librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            List<WinFormsApp2.Transaction> transactions = new List<WinFormsApp2.Transaction>();
            transactions = librarian.readTransactions();

            datatable.Columns.Add("ID");
            datatable.Columns.Add("Activity");
            datatable.Columns.Add("Date");
            datatable.Columns.Add("Member");
            datatable.Columns.Add("Book");

            if (transactions.Count > 0)
            {
                foreach (WinFormsApp2.Transaction transaction in transactions)
                {
                    datatable.Rows.Add(transaction.Id, transaction.TransactionName, transaction.Date, transaction.Member.FirstName, transaction.Book.Title);
                }
            }

            dataGridView1.DataSource = datatable;
            
        }
    }
}
