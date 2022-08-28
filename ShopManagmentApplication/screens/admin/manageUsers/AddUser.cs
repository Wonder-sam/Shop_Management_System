
using ShopManagementApplication.database;
using MySql.Data.MySqlClient;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens.admin.manageUsers
{
    internal class AddUser : UserControl
    {
        readonly static DatabaseConnection connection = new();
        private TextBox lastNameTextField;
        private GroupBox lastNameGroup;
        private TextBox firstNamesTextField;
        private Label lastNameLabel;
        private Label firstNamesLabel;
        private ComboBox genderComboBox;
        private GroupBox genderGroup;
        private DateTimePicker dobPicker;
        private GroupBox loginsGroup;
        private Label emailLabel;
        private Label passwordLabel;
        protected TextBox passwordTextField;
        private TextBox emailTextField;
        private Label genderLabel;
        private Label dobLabel;
        private Label phoneLabel;
        protected TextBox phoneTextField;
        private Label roleLabel;
        private ComboBox roleComboBox;
        private Button addUserBtn;
        private Panel addUserForm;
        private Label usernameLabel;
        private TextBox usernameTextField;
        public Label welcomeText;

        public AddUser()
        {
            InitializeComponent();

        }
        private void InitializeComponent()
        {
            this.welcomeText = new System.Windows.Forms.Label();
            this.lastNameTextField = new System.Windows.Forms.TextBox();
            this.lastNameGroup = new System.Windows.Forms.GroupBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNamesLabel = new System.Windows.Forms.Label();
            this.firstNamesTextField = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderGroup = new System.Windows.Forms.GroupBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneTextField = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.loginsGroup = new System.Windows.Forms.GroupBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.usernameTextField = new System.Windows.Forms.TextBox();
            this.emailTextField = new System.Windows.Forms.TextBox();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.addUserForm = new System.Windows.Forms.Panel();
            this.lastNameGroup.SuspendLayout();
            this.genderGroup.SuspendLayout();
            this.loginsGroup.SuspendLayout();
            this.addUserForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeText.ForeColor = System.Drawing.Color.SteelBlue;
            this.welcomeText.Location = new System.Drawing.Point(14, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(90, 22);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "New User";
            this.welcomeText.UseMnemonic = false;
            // 
            // lastNameTextField
            // 
            this.lastNameTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextField.Location = new System.Drawing.Point(16, 45);
            this.lastNameTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.lastNameTextField.Name = "lastNameTextField";
            this.lastNameTextField.Size = new System.Drawing.Size(182, 32);
            this.lastNameTextField.TabIndex = 1;
            // 
            // lastNameGroup
            // 
            this.lastNameGroup.Controls.Add(this.lastNameLabel);
            this.lastNameGroup.Controls.Add(this.firstNamesLabel);
            this.lastNameGroup.Controls.Add(this.firstNamesTextField);
            this.lastNameGroup.Controls.Add(this.lastNameTextField);
            this.lastNameGroup.Location = new System.Drawing.Point(14, 44);
            this.lastNameGroup.Name = "lastNameGroup";
            this.lastNameGroup.Size = new System.Drawing.Size(441, 96);
            this.lastNameGroup.TabIndex = 2;
            this.lastNameGroup.TabStop = false;
            this.lastNameGroup.Text = "Full Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 23);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNamesLabel
            // 
            this.firstNamesLabel.AutoSize = true;
            this.firstNamesLabel.Location = new System.Drawing.Point(227, 23);
            this.firstNamesLabel.Name = "firstNamesLabel";
            this.firstNamesLabel.Size = new System.Drawing.Size(72, 15);
            this.firstNamesLabel.TabIndex = 3;
            this.firstNamesLabel.Text = "First Names:";
            // 
            // firstNamesTextField
            // 
            this.firstNamesTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNamesTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNamesTextField.Location = new System.Drawing.Point(227, 45);
            this.firstNamesTextField.MaximumSize = new System.Drawing.Size(175, 32);
            this.firstNamesTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.firstNamesTextField.Name = "firstNamesTextField";
            this.firstNamesTextField.Size = new System.Drawing.Size(175, 32);
            this.firstNamesTextField.TabIndex = 1;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.genderComboBox.DropDownHeight = 80;
            this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genderComboBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.IntegralHeight = false;
            this.genderComboBox.ItemHeight = 26;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(16, 40);
            this.genderComboBox.MaximumSize = new System.Drawing.Size(175, 0);
            this.genderComboBox.MaxLength = 2;
            this.genderComboBox.MinimumSize = new System.Drawing.Size(175, 0);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(175, 32);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Text = "Male";
            this.genderComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.genderComboBox_DrawItem);
            // 
            // genderGroup
            // 
            this.genderGroup.Controls.Add(this.dobPicker);
            this.genderGroup.Controls.Add(this.phoneLabel);
            this.genderGroup.Controls.Add(this.dobLabel);
            this.genderGroup.Controls.Add(this.phoneTextField);
            this.genderGroup.Controls.Add(this.roleLabel);
            this.genderGroup.Controls.Add(this.genderLabel);
            this.genderGroup.Controls.Add(this.roleComboBox);
            this.genderGroup.Controls.Add(this.genderComboBox);
            this.genderGroup.Location = new System.Drawing.Point(14, 337);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.Size = new System.Drawing.Size(441, 154);
            this.genderGroup.TabIndex = 5;
            this.genderGroup.TabStop = false;
            this.genderGroup.Text = "Other Details";
            // 
            // dobPicker
            // 
            this.dobPicker.CustomFormat = "dd/MM/yyyy";
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(228, 40);
            this.dobPicker.MinimumSize = new System.Drawing.Size(192, 32);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(192, 32);
            this.dobPicker.TabIndex = 7;
            this.dobPicker.Value = new System.DateTime(2022, 8, 20, 16, 45, 15, 0);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(228, 81);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 15);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(228, 19);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(72, 15);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "Date of Bith:";
            // 
            // phoneTextField
            // 
            this.phoneTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextField.Location = new System.Drawing.Point(227, 102);
            this.phoneTextField.MaximumSize = new System.Drawing.Size(175, 32);
            this.phoneTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.phoneTextField.Name = "phoneTextField";
            this.phoneTextField.Size = new System.Drawing.Size(175, 32);
            this.phoneTextField.TabIndex = 1;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(17, 81);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 15);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "Role:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(17, 19);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 15);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.ItemHeight = 26;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.roleComboBox.Location = new System.Drawing.Point(17, 102);
            this.roleComboBox.MaximumSize = new System.Drawing.Size(175, 0);
            this.roleComboBox.MaxLength = 2;
            this.roleComboBox.MinimumSize = new System.Drawing.Size(175, 0);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(175, 32);
            this.roleComboBox.TabIndex = 4;
            this.roleComboBox.Text = "Attendant";
            this.roleComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roleComboBox_DrawItem);
            // 
            // loginsGroup
            // 
            this.loginsGroup.Controls.Add(this.usernameLabel);
            this.loginsGroup.Controls.Add(this.emailLabel);
            this.loginsGroup.Controls.Add(this.passwordLabel);
            this.loginsGroup.Controls.Add(this.passwordTextField);
            this.loginsGroup.Controls.Add(this.usernameTextField);
            this.loginsGroup.Controls.Add(this.emailTextField);
            this.loginsGroup.Location = new System.Drawing.Point(14, 164);
            this.loginsGroup.Name = "loginsGroup";
            this.loginsGroup.Size = new System.Drawing.Size(441, 161);
            this.loginsGroup.TabIndex = 2;
            this.loginsGroup.TabStop = false;
            this.loginsGroup.Text = "Login Details";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(16, 88);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(16, 23);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(227, 23);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextField
            // 
            this.passwordTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextField.Location = new System.Drawing.Point(227, 45);
            this.passwordTextField.MaximumSize = new System.Drawing.Size(175, 32);
            this.passwordTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.Size = new System.Drawing.Size(175, 32);
            this.passwordTextField.TabIndex = 1;
            // 
            // usernameTextField
            // 
            this.usernameTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextField.Location = new System.Drawing.Point(16, 110);
            this.usernameTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.Size = new System.Drawing.Size(182, 32);
            this.usernameTextField.TabIndex = 1;
            // 
            // emailTextField
            // 
            this.emailTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextField.Location = new System.Drawing.Point(16, 45);
            this.emailTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.emailTextField.Name = "emailTextField";
            this.emailTextField.Size = new System.Drawing.Size(182, 32);
            this.emailTextField.TabIndex = 1;
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addUserBtn.Location = new System.Drawing.Point(115, 503);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(213, 42);
            this.addUserBtn.TabIndex = 7;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // addUserForm
            // 
            this.addUserForm.Controls.Add(this.addUserBtn);
            this.addUserForm.Controls.Add(this.welcomeText);
            this.addUserForm.Controls.Add(this.genderGroup);
            this.addUserForm.Controls.Add(this.loginsGroup);
            this.addUserForm.Controls.Add(this.lastNameGroup);
            this.addUserForm.Location = new System.Drawing.Point(107, 13);
            this.addUserForm.Name = "addUserForm";
            this.addUserForm.Size = new System.Drawing.Size(472, 561);
            this.addUserForm.TabIndex = 8;
            // 
            // AddUser
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addUserForm);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(951, 614);
            this.lastNameGroup.ResumeLayout(false);
            this.lastNameGroup.PerformLayout();
            this.genderGroup.ResumeLayout(false);
            this.genderGroup.PerformLayout();
            this.loginsGroup.ResumeLayout(false);
            this.loginsGroup.PerformLayout();
            this.addUserForm.ResumeLayout(false);
            this.addUserForm.PerformLayout();
            this.ResumeLayout(false);

        }


        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string fname = firstNamesTextField.Text;
            string lname = lastNameTextField.Text;
            string gender = genderComboBox.Text;
            string username = usernameTextField.Text;
            string role = roleComboBox.Text;
            string email = emailTextField.Text;
            string password = passwordTextField.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string dob = dobPicker.Text;
            string phone = phoneTextField.Text;
            Console.WriteLine(dob);
            User newUser = new User(fname, lname, gender, username, role, dob, email, passwordHash, phone, false); ;
            newUser.CreateUser();

        
        }

        private void roleComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index > -1)
                e.Graphics.DrawString(roleComboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void genderComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index > -1)
                e.Graphics.DrawString(genderComboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }
    }
}
