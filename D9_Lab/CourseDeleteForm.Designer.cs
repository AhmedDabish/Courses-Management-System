namespace D9_Lab
{
    partial class CourseDeleteForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label    lblTitle, lblSelect;
        private ComboBox cmbCourses;
        private Button   btnDelete, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSelect = new Label();
            cmbCourses = new ComboBox();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(180, 40, 40);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delete Course";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSelect
            // 
            lblSelect.Font = new Font("Tahoma", 12F);
            lblSelect.Location = new Point(40, 95);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(140, 28);
            lblSelect.TabIndex = 1;
            lblSelect.Text = "Select Course:";
            // 
            // cmbCourses
            // 
            cmbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourses.Font = new Font("Tahoma", 12F);
            cmbCourses.Location = new Point(195, 92);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(280, 32);
            cmbCourses.TabIndex = 2;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(180, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(120, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 48);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 12F);
            btnCancel.Location = new Point(275, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // CourseDeleteForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(520, 280);
            Controls.Add(lblTitle);
            Controls.Add(lblSelect);
            Controls.Add(cmbCourses);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CourseDeleteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Course";
            Load += CourseDeleteForm_Load;
            ResumeLayout(false);
        }
    }
}
