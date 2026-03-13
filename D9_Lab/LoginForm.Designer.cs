namespace D9_Lab
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label      lblTitle, lblUser, lblPass;
        private TextBox    txtUserName, txtUserPass;
        private Button     btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUser = new Label();
            lblPass = new Label();
            txtUserName = new TextBox();
            txtUserPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(40, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome — Please Login";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Tahoma", 12F);
            lblUser.Location = new Point(60, 110);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(110, 28);
            lblUser.TabIndex = 1;
            lblUser.Text = "UserName:";
            // 
            // lblPass
            // 
            lblPass.Font = new Font("Tahoma", 12F);
            lblPass.Location = new Point(60, 165);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(110, 28);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Tahoma", 12F);
            txtUserName.Location = new Point(185, 107);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(230, 32);
            txtUserName.TabIndex = 2;
            // 
            // txtUserPass
            // 
            txtUserPass.Font = new Font("Tahoma", 12F);
            txtUserPass.Location = new Point(185, 162);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PasswordChar = '●';
            txtUserPass.Size = new Size(230, 32);
            txtUserPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(175, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 50);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(520, 360);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(txtUserName);
            Controls.Add(lblPass);
            Controls.Add(txtUserPass);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
