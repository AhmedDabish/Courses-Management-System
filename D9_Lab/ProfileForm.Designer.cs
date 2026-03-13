namespace D9_Lab
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picProfile;
        private Label      lblTitle, lblName, lblNameVal, lblTrack, lblTrackVal;
        private Button     btnChooseImage, btnEdit, btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            picProfile     = new PictureBox();
            lblTitle       = new Label();
            lblName        = new Label();
            lblNameVal     = new Label();
            lblTrack       = new Label();
            lblTrackVal    = new Label();
            btnChooseImage = new Button();
            btnEdit        = new Button();
            btnClose       = new Button();

            SuspendLayout();

            this.Text            = "Profile";
            this.ClientSize      = new Size(560, 520);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.StartPosition   = FormStartPosition.CenterParent;
            this.AutoScaleMode   = AutoScaleMode.None;
            this.Load           += ProfileForm_Load;

            lblTitle.Text      = "My Profile";
            lblTitle.Font      = new Font("Tahoma", 17F, FontStyle.Bold);
            lblTitle.Location  = new Point(30, 18);
            lblTitle.Size      = new Size(500, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            picProfile.Location    = new Point(190, 75);
            picProfile.Size        = new Size(180, 180);
            picProfile.SizeMode    = PictureBoxSizeMode.Zoom;
            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.BackColor   = Color.FromArgb(220, 220, 220);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();

            btnChooseImage.Text      = "📷  Choose Image";
            btnChooseImage.Font      = new Font("Tahoma", 11F);
            btnChooseImage.Location  = new Point(185, 268);
            btnChooseImage.Size      = new Size(190, 38);
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Click    += btnChooseImage_Click;

            lblName.Text      = "Username:";
            lblName.Font      = new Font("Tahoma", 12F, FontStyle.Bold);
            lblName.Location  = new Point(80, 330);
            lblName.Size      = new Size(130, 28);

            lblNameVal.Font     = new Font("Tahoma", 12F);
            lblNameVal.Location = new Point(220, 330);
            lblNameVal.Size     = new Size(270, 28);

            lblTrack.Text      = "Track:";
            lblTrack.Font      = new Font("Tahoma", 12F, FontStyle.Bold);
            lblTrack.Location  = new Point(80, 375);
            lblTrack.Size      = new Size(130, 28);

            lblTrackVal.Font     = new Font("Tahoma", 12F);
            lblTrackVal.Location = new Point(220, 375);
            lblTrackVal.Size     = new Size(270, 28);

            btnEdit.Text      = "✏️  Edit Info";
            btnEdit.Font      = new Font("Tahoma", 12F);
            btnEdit.Location  = new Point(100, 440);
            btnEdit.Size      = new Size(160, 48);
            btnEdit.BackColor = Color.FromArgb(0, 120, 215);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Click    += btnEdit_Click;

            btnClose.Text      = "Close";
            btnClose.Font      = new Font("Tahoma", 12F);
            btnClose.Location  = new Point(300, 440);
            btnClose.Size      = new Size(160, 48);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Click    += btnClose_Click;

            this.Controls.AddRange(new Control[] {
                lblTitle, picProfile, btnChooseImage,
                lblName, lblNameVal, lblTrack, lblTrackVal,
                btnEdit, btnClose
            });

            ResumeLayout(false);
        }
    }
}
