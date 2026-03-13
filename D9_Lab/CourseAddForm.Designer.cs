namespace D9_Lab
{
    partial class CourseAddForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label   lblTitle, lblName, lblDesc;
        private TextBox txtName, txtDesc;
        private Button  btnSave, btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            lblDesc = new Label();
            txtName = new TextBox();
            txtDesc = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Course";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Font = new Font("Tahoma", 12F);
            lblName.Location = new Point(40, 85);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Course Name:";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Tahoma", 12F);
            lblDesc.Location = new Point(40, 140);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(130, 28);
            lblDesc.TabIndex = 3;
            lblDesc.Text = "Description:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 12F);
            txtName.Location = new Point(185, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 32);
            txtName.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Tahoma", 12F);
            txtDesc.Location = new Point(185, 137);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(290, 100);
            txtDesc.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 80);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(130, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 46);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 12F);
            btnCancel.Location = new Point(280, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 46);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // CourseAddForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(540, 380);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblDesc);
            Controls.Add(txtDesc);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CourseAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Course";
            Load += CourseAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
