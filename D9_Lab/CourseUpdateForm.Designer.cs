namespace D9_Lab
{
    partial class CourseUpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label    lblTitle, lblSelect, lblName, lblDesc;
        private ComboBox cmbCourses;
        private TextBox  txtName, txtDesc;
        private Button   btnUpdate, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSelect = new Label();
            lblName = new Label();
            lblDesc = new Label();
            cmbCourses = new ComboBox();
            txtName = new TextBox();
            txtDesc = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Update Course";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSelect
            // 
            lblSelect.Font = new Font("Tahoma", 12F);
            lblSelect.Location = new Point(40, 85);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(140, 28);
            lblSelect.TabIndex = 1;
            lblSelect.Text = "Select Course:";
            // 
            // lblName
            // 
            lblName.Font = new Font("Tahoma", 12F);
            lblName.Location = new Point(40, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 28);
            lblName.TabIndex = 3;
            lblName.Text = "Course Name:";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Tahoma", 12F);
            lblDesc.Location = new Point(40, 195);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(140, 28);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Description:";
            // 
            // cmbCourses
            // 
            cmbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourses.Font = new Font("Tahoma", 12F);
            cmbCourses.Location = new Point(195, 82);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(310, 32);
            cmbCourses.TabIndex = 2;
            cmbCourses.SelectedIndexChanged += cmbCourses_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 12F);
            txtName.Location = new Point(195, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 32);
            txtName.TabIndex = 4;
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Tahoma", 12F);
            txtDesc.Location = new Point(195, 192);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(310, 100);
            txtDesc.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(130, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 48);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 12F);
            btnCancel.Location = new Point(290, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 48);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // CourseUpdateForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(560, 440);
            Controls.Add(lblTitle);
            Controls.Add(lblSelect);
            Controls.Add(cmbCourses);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblDesc);
            Controls.Add(txtDesc);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CourseUpdateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Course";
            Load += CourseUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
