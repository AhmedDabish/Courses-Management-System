using D9_Lab.DataLayer;

namespace D9_Lab
{
    public partial class ProfileEditForm : Form
    {
        public ProfileEditForm()
        {
            InitializeComponent();
        }

        private void ProfileEditForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = UserData.CurrentUser.UserName;
            txtTrack.Text    = UserData.CurrentUser.Track;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserData.CurrentUser.UserName = txtUserName.Text.Trim();
            UserData.CurrentUser.Track    = txtTrack.Text.Trim();

            MessageBox.Show("Profile updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
