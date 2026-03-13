namespace D9_Lab
{
    partial class CoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label  lblWelcome;
        private Panel  pnlSidebar;
        private Button btnAddCourse, btnDisplayCourses, btnUpdateCourse, btnDeleteCourse;
        private Button btnProfile, btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome        = new Label();
            pnlSidebar        = new Panel();
            btnAddCourse      = new Button();
            btnDisplayCourses = new Button();
            btnUpdateCourse   = new Button();
            btnDeleteCourse   = new Button();
            btnProfile        = new Button();
            btnLogout         = new Button();

            SuspendLayout();

            // Form
            this.Text          = "Courses Application";
            this.ClientSize    = new Size(950, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor     = Color.White;
            this.Load         += CoursesForm_Load;

            // Top welcome bar
            lblWelcome.Dock      = DockStyle.Top;
            lblWelcome.Height    = 58;
            lblWelcome.Font      = new Font("Tahoma", 15F, FontStyle.Bold);
            lblWelcome.BackColor = Color.FromArgb(0, 120, 215);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Text      = "Welcome";

            // Sidebar
            pnlSidebar.Dock      = DockStyle.Left;
            pnlSidebar.Width     = 260;
            pnlSidebar.BackColor = Color.FromArgb(30, 30, 45);

            var lblCourses = new Label();
            lblCourses.Text      = "📚  Courses";
            lblCourses.Font      = new Font("Tahoma", 13F, FontStyle.Bold);
            lblCourses.ForeColor = Color.FromArgb(150, 200, 255);
            lblCourses.Location  = new Point(14, 26);
            lblCourses.Size      = new Size(230, 32);

            MakeSideBtn(btnAddCourse,      "➕  Add New Course",      75);
            MakeSideBtn(btnDisplayCourses, "📋  Display App Courses", 135);
            MakeSideBtn(btnUpdateCourse,   "✏️  Update Course",       195);
            MakeSideBtn(btnDeleteCourse,   "🗑️  Delete Course",       255);

            var lblProfile = new Label();
            lblProfile.Text      = "👤  Profile";
            lblProfile.Font      = new Font("Tahoma", 13F, FontStyle.Bold);
            lblProfile.ForeColor = Color.FromArgb(150, 200, 255);
            lblProfile.Location  = new Point(14, 335);
            lblProfile.Size      = new Size(230, 32);

            MakeSideBtn(btnProfile, "🖼️  Profile", 378);

            btnLogout.Text      = "🚪  Logout";
            btnLogout.Font      = new Font("Tahoma", 12F);
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(200, 50, 50);
            btnLogout.BackColor = Color.FromArgb(180, 40, 40);
            btnLogout.Location  = new Point(14, 530);
            btnLogout.Size      = new Size(232, 48);
            btnLogout.Click    += btnLogout_Click;

            btnAddCourse.Click      += btnAddCourse_Click;
            btnDisplayCourses.Click += btnDisplayCourses_Click;
            btnUpdateCourse.Click   += btnUpdateCourse_Click;
            btnDeleteCourse.Click   += btnDeleteCourse_Click;
            btnProfile.Click        += btnProfile_Click;

            pnlSidebar.Controls.AddRange(new Control[] {
                lblCourses,
                btnAddCourse, btnDisplayCourses, btnUpdateCourse, btnDeleteCourse,
                lblProfile, btnProfile, btnLogout
            });

            var lblHint = new Label();
            lblHint.Text      = "← Use the sidebar to navigate";
            lblHint.Font      = new Font("Tahoma", 13F, FontStyle.Italic);
            lblHint.ForeColor = Color.Gray;
            lblHint.Location  = new Point(380, 280);
            lblHint.AutoSize  = true;

            this.Controls.AddRange(new Control[] { lblWelcome, pnlSidebar, lblHint });

            ResumeLayout(false);
        }

        private void MakeSideBtn(Button b, string text, int top)
        {
            b.Text      = text;
            b.Font      = new Font("Tahoma", 12F);
            b.ForeColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Color.Transparent;
            b.Location  = new Point(14, top);
            b.Size      = new Size(232, 48);
            b.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
