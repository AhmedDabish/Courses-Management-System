using D9_Lab.DataLayer;

namespace D9_Lab
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            var u = UserData.CurrentUser;
            lblWelcome.Text = $"Welcome : {u.UserName}          Track : {u.Track}";
        }

        // ── Sidebar buttons ───────────────────────────────────────

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            new CourseAddForm().ShowDialog();
        }

        private void btnDisplayCourses_Click(object sender, EventArgs e)
        {
            var courses = CourseData.GetByTrack(UserData.CurrentUser.Track);
            string msg = courses.Count == 0
                ? "No courses found for your track."
                : string.Join("\n", courses.ConvertAll(c => $"• [{c.Id}] {c.Name} — {c.Description}"));
            MessageBox.Show(msg, "App Courses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            new CourseUpdateForm().ShowDialog();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            new CourseDeleteForm().ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserData.CurrentUser = null;
                new LoginForm().Show();
                this.Close();
            }
        }
    }
}
