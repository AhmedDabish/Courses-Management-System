using D9_Lab.DataLayer;

namespace D9_Lab
{
    public partial class CourseAddForm : Form
    {
        public CourseAddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Course name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var course = new CourseData.Course
            {
                Name = txtName.Text.Trim(),
                Description = txtDesc.Text.Trim(),
                Track = UserData.CurrentUser.Track
            };

            CourseData.Add(course);
            MessageBox.Show("Course added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void CourseAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
