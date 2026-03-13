    using D9_Lab.DataLayer;

    namespace D9_Lab
    {
    public partial class CourseDeleteForm : Form
    {
        public CourseDeleteForm()
        {
            InitializeComponent();
        }

        private void CourseDeleteForm_Load(object sender, EventArgs e)
        {
            var courses = CourseData.GetByTrack(UserData.CurrentUser.Track);
            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "Id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCourses.SelectedItem is not CourseData.Course selected) return;

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete \"{selected.Name}\"?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                CourseData.Delete(selected.Id);
                MessageBox.Show("Course deleted.", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
