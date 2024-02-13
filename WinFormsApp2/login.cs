using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (IsCorrect(Username, Password))
            {
                MemberLogin mainform = new MemberLogin();
                mainform.Show();
                Visible = false;
            }
            if (admin (Username , Password))
            {
                Librarian librarian = new Librarian();
                librarian.Show();
                Visible = false;
            }
        }

        private bool IsCorrect(string username, string password)
        {
            return (username == "chathu" && password == "2005");
        }

        private bool admin (string username, string password)
        {
            return ( username == "admin" &&  password == "0000");
        }
        
    }
}
