using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ShopManagementApplication.classes;
using ShopManagementApplication.database;

namespace ShopManagementApplication.screens.admin.manageUsers
{
    internal class UpdateUser : UserControl
    {
        readonly static DatabaseConnection connection = new();
        private Label updateUserHeader;
        private Label usernameLabel;
        private Button button1;
        private GroupBox findUserGroup;
        private GroupBox foundUserGroup;
        private TextBox foundUsernameTextField;
        private Label foundUsernameLabel;
        private TextBox passwordTextField;
        private Label passwordLabel;
        private TextBox emailTextField;
        private Label emailLable;
        private TextBox firstNameTextField;
        private Label firstNameLabel;
        private TextBox lastNameTextField;
        private Label lastNameLabel;
        private ComboBox roleComboBox;
        private ComboBox genderComboBox;
        private DateTimePicker dobDatetimePicker;
        private Label genderLabel;
        private Label roleLabel;
        private Label dobLabel;
        private TextBox phoneTextField;
        private Label phoneLabel;
        private Button updateBtn;
        private TextBox usernameTextField;

        public UpdateUser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.updateUserHeader = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.findUserGroup = new System.Windows.Forms.GroupBox();
            this.foundUserGroup = new System.Windows.Forms.GroupBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneTextField = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.foundUsernameTextField = new System.Windows.Forms.TextBox();
            this.foundUsernameLabel = new System.Windows.Forms.Label();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailTextField = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.firstNameTextField = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextField = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.findUserGroup.SuspendLayout();
            this.foundUserGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateUserHeader
            // 
            this.updateUserHeader.AutoSize = true;
            this.updateUserHeader.BackColor = System.Drawing.Color.Transparent;
            this.updateUserHeader.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateUserHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateUserHeader.Location = new System.Drawing.Point(114, 25);
            this.updateUserHeader.Name = "updateUserHeader";
            this.updateUserHeader.Size = new System.Drawing.Size(155, 28);
            this.updateUserHeader.TabIndex = 0;
            this.updateUserHeader.Text = "Update User";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(20, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextField
            // 
            this.usernameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextField.Location = new System.Drawing.Point(20, 49);
            this.usernameTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.PlaceholderText = "Username";
            this.usernameTextField.Size = new System.Drawing.Size(203, 32);
            this.usernameTextField.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(244, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findUserGroup
            // 
            this.findUserGroup.Controls.Add(this.usernameTextField);
            this.findUserGroup.Controls.Add(this.button1);
            this.findUserGroup.Controls.Add(this.usernameLabel);
            this.findUserGroup.Location = new System.Drawing.Point(114, 72);
            this.findUserGroup.Name = "findUserGroup";
            this.findUserGroup.Size = new System.Drawing.Size(450, 92);
            this.findUserGroup.TabIndex = 4;
            this.findUserGroup.TabStop = false;
            this.findUserGroup.Text = "Find User";
            // 
            // foundUserGroup
            // 
            this.foundUserGroup.Controls.Add(this.roleComboBox);
            this.foundUserGroup.Controls.Add(this.genderComboBox);
            this.foundUserGroup.Controls.Add(this.dobDatetimePicker);
            this.foundUserGroup.Controls.Add(this.genderLabel);
            this.foundUserGroup.Controls.Add(this.roleLabel);
            this.foundUserGroup.Controls.Add(this.dobLabel);
            this.foundUserGroup.Controls.Add(this.phoneTextField);
            this.foundUserGroup.Controls.Add(this.phoneLabel);
            this.foundUserGroup.Controls.Add(this.foundUsernameTextField);
            this.foundUserGroup.Controls.Add(this.foundUsernameLabel);
            this.foundUserGroup.Controls.Add(this.passwordTextField);
            this.foundUserGroup.Controls.Add(this.passwordLabel);
            this.foundUserGroup.Controls.Add(this.emailTextField);
            this.foundUserGroup.Controls.Add(this.emailLable);
            this.foundUserGroup.Controls.Add(this.firstNameTextField);
            this.foundUserGroup.Controls.Add(this.firstNameLabel);
            this.foundUserGroup.Controls.Add(this.lastNameTextField);
            this.foundUserGroup.Controls.Add(this.lastNameLabel);
            this.foundUserGroup.Location = new System.Drawing.Point(114, 181);
            this.foundUserGroup.Name = "foundUserGroup";
            this.foundUserGroup.Size = new System.Drawing.Size(450, 370);
            this.foundUserGroup.TabIndex = 5;
            this.foundUserGroup.TabStop = false;
            this.foundUserGroup.Text = "Found User";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.roleComboBox.ItemHeight = 26;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.roleComboBox.Location = new System.Drawing.Point(229, 257);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(203, 32);
            this.roleComboBox.TabIndex = 4;
            this.roleComboBox.Text = "Attendant";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 26;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(20, 257);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(203, 32);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Text = "Male";
            // 
            // dobDatetimePicker
            // 
            this.dobDatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDatetimePicker.Location = new System.Drawing.Point(229, 186);
            this.dobDatetimePicker.MinimumSize = new System.Drawing.Size(203, 32);
            this.dobDatetimePicker.Name = "dobDatetimePicker";
            this.dobDatetimePicker.Size = new System.Drawing.Size(203, 32);
            this.dobDatetimePicker.TabIndex = 3;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(20, 234);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 15);
            this.genderLabel.TabIndex = 1;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.Click += new System.EventHandler(this.foundUsernameLabel_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(229, 234);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 15);
            this.roleLabel.TabIndex = 1;
            this.roleLabel.Text = "Role:";
            this.roleLabel.Click += new System.EventHandler(this.foundUsernameLabel_Click);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(229, 167);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(73, 15);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date of Birth";
            this.dobLabel.Click += new System.EventHandler(this.foundUsernameLabel_Click);
            // 
            // phoneTextField
            // 
            this.phoneTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextField.Location = new System.Drawing.Point(20, 324);
            this.phoneTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.phoneTextField.Name = "phoneTextField";
            this.phoneTextField.PlaceholderText = "Phone";
            this.phoneTextField.Size = new System.Drawing.Size(203, 32);
            this.phoneTextField.TabIndex = 2;
            this.phoneTextField.TextChanged += new System.EventHandler(this.foundUsernameTextField_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(20, 305);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 15);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone:";
            this.phoneLabel.Click += new System.EventHandler(this.foundUsernameLabel_Click);
            // 
            // foundUsernameTextField
            // 
            this.foundUsernameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foundUsernameTextField.Location = new System.Drawing.Point(20, 186);
            this.foundUsernameTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.foundUsernameTextField.Name = "foundUsernameTextField";
            this.foundUsernameTextField.PlaceholderText = "Username";
            this.foundUsernameTextField.Size = new System.Drawing.Size(203, 32);
            this.foundUsernameTextField.TabIndex = 2;
            this.foundUsernameTextField.TextChanged += new System.EventHandler(this.foundUsernameTextField_TextChanged);
            // 
            // foundUsernameLabel
            // 
            this.foundUsernameLabel.AutoSize = true;
            this.foundUsernameLabel.Location = new System.Drawing.Point(20, 167);
            this.foundUsernameLabel.Name = "foundUsernameLabel";
            this.foundUsernameLabel.Size = new System.Drawing.Size(63, 15);
            this.foundUsernameLabel.TabIndex = 1;
            this.foundUsernameLabel.Text = "Username:";
            this.foundUsernameLabel.Click += new System.EventHandler(this.foundUsernameLabel_Click);
            // 
            // passwordTextField
            // 
            this.passwordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextField.Location = new System.Drawing.Point(229, 121);
            this.passwordTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PlaceholderText = "Password";
            this.passwordTextField.Size = new System.Drawing.Size(203, 32);
            this.passwordTextField.TabIndex = 2;
            this.passwordTextField.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(229, 102);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // emailTextField
            // 
            this.emailTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextField.Location = new System.Drawing.Point(20, 121);
            this.emailTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.emailTextField.Name = "emailTextField";
            this.emailTextField.PlaceholderText = "Email";
            this.emailTextField.Size = new System.Drawing.Size(203, 32);
            this.emailTextField.TabIndex = 2;
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Location = new System.Drawing.Point(20, 102);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(39, 15);
            this.emailLable.TabIndex = 1;
            this.emailLable.Text = "Email:";
            // 
            // firstNameTextField
            // 
            this.firstNameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTextField.Location = new System.Drawing.Point(229, 51);
            this.firstNameTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.firstNameTextField.Name = "firstNameTextField";
            this.firstNameTextField.PlaceholderText = "Username";
            this.firstNameTextField.Size = new System.Drawing.Size(203, 32);
            this.firstNameTextField.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(229, 32);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameTextField
            // 
            this.lastNameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextField.Location = new System.Drawing.Point(20, 51);
            this.lastNameTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.lastNameTextField.Name = "lastNameTextField";
            this.lastNameTextField.PlaceholderText = "Last Name";
            this.lastNameTextField.Size = new System.Drawing.Size(203, 32);
            this.lastNameTextField.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(20, 32);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(222, 557);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(213, 42);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // UpdateUser
            // 
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.foundUserGroup);
            this.Controls.Add(this.findUserGroup);
            this.Controls.Add(this.updateUserHeader);
            this.Name = "UpdateUser";
            this.Size = new System.Drawing.Size(689, 614);
            this.findUserGroup.ResumeLayout(false);
            this.findUserGroup.PerformLayout();
            this.foundUserGroup.ResumeLayout(false);
            this.foundUserGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void foundUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void foundUsernameTextField_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextField.Text;
            User targetUser = User.GetUser(username);
            if (targetUser == null)
            {
                MessageBox.Show("User doesnt exist");
            }
            else
            {
                firstNameTextField.Text = targetUser.FirstNames;
                lastNameTextField.Text = targetUser.LastName;
                usernameTextField.Text = targetUser.Username;
                genderComboBox.Text = targetUser.Gender;
                roleComboBox.Text = targetUser.Role;
                emailTextField.Text = targetUser.Email;
                passwordTextField.Text = targetUser.Password;
                dobDatetimePicker.Text = targetUser.Dob.ToString();
                phoneTextField.Text = targetUser.Phone;
            }

           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string fname = firstNameTextField.Text;
            string lname = lastNameTextField.Text;
            string username = usernameTextField.Text.Trim();
            string gender = genderComboBox.Text;
            string role = roleComboBox.Text;
            string email = emailTextField.Text;
            string password = passwordTextField.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string dob = dobDatetimePicker.Text;
            string phone = phoneTextField.Text;

            User newUser = new User(fname, lname, gender, username, role, dob, email, phone, false); ;
            newUser.UpdateUser();
        }
  
    }
}
