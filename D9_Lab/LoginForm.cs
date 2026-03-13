using D9_Lab.DataLayer;

namespace D9_Lab
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtUserPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = UserData.Login(username, password);

            if (user != null)
            {
                UserData.CurrentUser = user;
                MessageBox.Show($"Welcome, {user.UserName}!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var coursesForm = new CoursesForm();
                coursesForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPass.Clear();
                txtUserPass.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
