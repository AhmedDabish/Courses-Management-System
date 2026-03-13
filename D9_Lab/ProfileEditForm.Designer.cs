namespace D9_Lab
{
    partial class ProfileEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label   lblTitle, lblUser, lblTrack;
        private TextBox txtUserName, txtTrack;
        private Button  btnSave, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle    = new Label();
            lblUser     = new Label();
            lblTrack    = new Label();
            txtUserName = new TextBox();
            txtTrack    = new TextBox();
            btnSave     = new Button();
            btnCancel   = new Button();

            SuspendLayout();

            this.Text            = "Edit Profile";
            this.ClientSize      = new Size(520, 320);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.StartPosition   = FormStartPosition.CenterParent;
            this.AutoScaleMode   = AutoScaleMode.None;
            this.Load           += ProfileEditForm_Load;

            lblTitle.Text      = "Edit Personal Information";
            lblTitle.Font      = new Font("Tahoma", 15F, FontStyle.Bold);
            lblTitle.Location  = new Point(30, 20);
            lblTitle.Size      = new Size(460, 36);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblUser.Text     = "Username:";
            lblUser.Font     = new Font("Tahoma", 12F);
            lblUser.Location = new Point(40, 90);
            lblUser.Size     = new Size(120, 28);

            txtUserName.Location = new Point(175, 87);
            txtUserName.Size     = new Size(280, 30);
            txtUserName.Font     = new Font("Tahoma", 12F);

            lblTrack.Text     = "Track:";
            lblTrack.Font     = new Font("Tahoma", 12F);
            lblTrack.Location = new Point(40, 148);
            lblTrack.Size     = new Size(120, 28);

            txtTrack.Location = new Point(175, 145);
            txtTrack.Size     = new Size(280, 30);
            txtTrack.Font     = new Font("Tahoma", 12F);

            btnSave.Text      = "Save";
            btnSave.Font      = new Font("Tahoma", 12F, FontStyle.Bold);
            btnSave.Location  = new Point(110, 228);
            btnSave.Size      = new Size(130, 48);
            btnSave.BackColor = Color.FromArgb(0, 150, 80);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click    += btnSave_Click;

            btnCancel.Text      = "Cancel";
            btnCancel.Font      = new Font("Tahoma", 12F);
            btnCancel.Location  = new Point(270, 228);
            btnCancel.Size      = new Size(130, 48);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Click    += btnCancel_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, lblUser, txtUserName, lblTrack, txtTrack, btnSave, btnCancel
            });

            ResumeLayout(false);
        }
    }
}
