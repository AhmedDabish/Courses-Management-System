using D9_Lab.DataLayer;

namespace D9_Lab
{
    public partial class CourseUpdateForm : Form
    {
        public CourseUpdateForm()
        {
            InitializeComponent();
        }

        private void CourseUpdateForm_Load(object sender, EventArgs e)
        {
            var courses = CourseData.GetByTrack(UserData.CurrentUser.Track);
            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "Id";
            if (courses.Count > 0) LoadSelected();
        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e) => LoadSelected();

        private void LoadSelected()
        {
            if (cmbCourses.SelectedItem is CourseData.Course c)
            {
                txtName.Text = c.Name;
                txtDesc.Text = c.Description;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedItem is not CourseData.Course selected) return;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Course name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CourseData.Update(new CourseData.Course
            {
                Id = selected.Id,
                Name = txtName.Text.Trim(),
                Description = txtDesc.Text.Trim(),
                Track = selected.Track
            });

            MessageBox.Show("Course updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
