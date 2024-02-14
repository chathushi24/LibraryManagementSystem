using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class login : Form
    {
        Library library;

        public login()
        {
            library = new Library();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            // Get the target user from database
            var user = libraryDatabase.getRecord<User>("Username", Username, "Users");

            // validate the user and user login using users login method
            if (user == null)
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (user.userlogin(Username, Password))
                {
                    if (user.IsAdmin)
                    {
                        // Typecast user to an Admin type and pass
                        Librarian librarian = new Librarian(user as Admin, library);
                        librarian.Show();
                        Visible = false;
                    }
                    // else redirect to the member's form
                    else
                    {
                        // Typecast user to a member type and pass
                        MemberLogin mainform = new MemberLogin(user as Member, library);
                        mainform.Show();
                        Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
    }
}
