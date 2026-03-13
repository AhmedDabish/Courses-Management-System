using D9_Lab.DataLayer;

namespace D9_Lab
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            var u = UserData.CurrentUser;
            lblNameVal.Text  = u.UserName;
            lblTrackVal.Text = u.Track;

            if (!string.IsNullOrEmpty(u.ImagePath) && File.Exists(u.ImagePath))
                picProfile.Image = Image.FromFile(u.ImagePath);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dlg.Title  = "Select Profile Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                UserData.CurrentUser.ImagePath = dlg.FileName;
                picProfile.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new ProfileEditForm().ShowDialog();
            // Refresh after edit
            lblNameVal.Text  = UserData.CurrentUser.UserName;
            lblTrackVal.Text = UserData.CurrentUser.Track;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
