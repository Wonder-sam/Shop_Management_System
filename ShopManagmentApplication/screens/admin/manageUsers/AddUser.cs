
using ShopManagementApp.database;
using MySql.Data.MySqlClient;

namespace ShopManagementApp.screens.admin.manageUsers
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
        protected TextBox pincodeTextField;
        private Label pincodeLabel;
        private Button button1;
        private Button addUserBtn;
        private Panel addUserForm;
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.emailTextField = new System.Windows.Forms.TextBox();
            this.pincodeTextField = new System.Windows.Forms.TextBox();
            this.pincodeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.welcomeText.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeText.ForeColor = System.Drawing.Color.SteelBlue;
            this.welcomeText.Location = new System.Drawing.Point(14, 0);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(116, 28);
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
            this.lastNameTextField.PlaceholderText = "Last Name";
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
            this.firstNamesTextField.PlaceholderText = "First Names";
            this.firstNamesTextField.Size = new System.Drawing.Size(175, 32);
            this.firstNamesTextField.TabIndex = 1;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 26;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.genderComboBox.Location = new System.Drawing.Point(16, 40);
            this.genderComboBox.MaximumSize = new System.Drawing.Size(175, 0);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(175, 0);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(175, 32);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Text = "Male";
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
            this.genderGroup.Location = new System.Drawing.Point(14, 266);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.Size = new System.Drawing.Size(441, 154);
            this.genderGroup.TabIndex = 5;
            this.genderGroup.TabStop = false;
            this.genderGroup.Text = "Other Details";
            // 
            // dobPicker
            // 
            this.dobPicker.CustomFormat = "mm/dd/yyy";
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(228, 40);
            this.dobPicker.MinimumSize = new System.Drawing.Size(192, 32);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(192, 32);
            this.dobPicker.TabIndex = 7;
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
            this.phoneTextField.PlaceholderText = "Phone";
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
            "Supervisor",
            "Attendant"});
            this.roleComboBox.Location = new System.Drawing.Point(17, 102);
            this.roleComboBox.MaximumSize = new System.Drawing.Size(175, 0);
            this.roleComboBox.MinimumSize = new System.Drawing.Size(175, 0);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(175, 32);
            this.roleComboBox.TabIndex = 4;
            this.roleComboBox.Text = "Attendant";
            // 
            // loginsGroup
            // 
            this.loginsGroup.Controls.Add(this.emailLabel);
            this.loginsGroup.Controls.Add(this.passwordLabel);
            this.loginsGroup.Controls.Add(this.passwordTextField);
            this.loginsGroup.Controls.Add(this.emailTextField);
            this.loginsGroup.Location = new System.Drawing.Point(14, 164);
            this.loginsGroup.Name = "loginsGroup";
            this.loginsGroup.Size = new System.Drawing.Size(441, 96);
            this.loginsGroup.TabIndex = 2;
            this.loginsGroup.TabStop = false;
            this.loginsGroup.Text = "Login Details";
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
            this.passwordTextField.PlaceholderText = "Password";
            this.passwordTextField.Size = new System.Drawing.Size(175, 32);
            this.passwordTextField.TabIndex = 1;
            // 
            // emailTextField
            // 
            this.emailTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextField.Location = new System.Drawing.Point(16, 45);
            this.emailTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.emailTextField.Name = "emailTextField";
            this.emailTextField.PlaceholderText = "Email";
            this.emailTextField.Size = new System.Drawing.Size(182, 32);
            this.emailTextField.TabIndex = 1;
            // 
            // pincodeTextField
            // 
            this.pincodeTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pincodeTextField.Location = new System.Drawing.Point(52, 451);
            this.pincodeTextField.MaximumSize = new System.Drawing.Size(175, 32);
            this.pincodeTextField.MinimumSize = new System.Drawing.Size(175, 32);
            this.pincodeTextField.Name = "pincodeTextField";
            this.pincodeTextField.PlaceholderText = "pincode";
            this.pincodeTextField.Size = new System.Drawing.Size(175, 32);
            this.pincodeTextField.TabIndex = 1;
            // 
            // pincodeLabel
            // 
            this.pincodeLabel.AutoSize = true;
            this.pincodeLabel.Location = new System.Drawing.Point(52, 444);
            this.pincodeLabel.Name = "pincodeLabel";
            this.pincodeLabel.Size = new System.Drawing.Size(53, 15);
            this.pincodeLabel.TabIndex = 3;
            this.pincodeLabel.Text = "Pincode:";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(257, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addUserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addUserBtn.Location = new System.Drawing.Point(116, 501);
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
            this.addUserForm.Controls.Add(this.button1);
            this.addUserForm.Controls.Add(this.genderGroup);
            this.addUserForm.Controls.Add(this.pincodeLabel);
            this.addUserForm.Controls.Add(this.loginsGroup);
            this.addUserForm.Controls.Add(this.lastNameGroup);
            this.addUserForm.Controls.Add(this.pincodeTextField);
            this.addUserForm.Location = new System.Drawing.Point(107, 13);
            this.addUserForm.Name = "addUserForm";
            this.addUserForm.Size = new System.Drawing.Size(472, 575);
            this.addUserForm.TabIndex = 8;
            // 
            // AddUser
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addUserForm);
            this.Name = "AddUser";
            this.Size = new System.Drawing.Size(700, 591);
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
            string pincode = pincodeTextField.Text;
            string role = roleComboBox.Text;
            string email = emailTextField.Text;
            string password = passwordTextField.Text;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string dob = dobPicker.Text;
            string phone = phoneTextField.Text;
            CreateUser(fname, email, passwordHash, dob, gender, role, phone, pincode);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int pincode = random.Next(1000, 9999);
            pincodeTextField.Text = pincode.ToString();
        }

        public void CreateUser(string name, string email, string password, string dob, string gender, string role, string phone, string pincode)
        {
            String insertQuery = $"INSERT INTO users(name, role, dob, email, password, phone, gender, photo, pincode)" +
                                $" VALUES('{name}','{role}',STR_TO_DATE('{dob}','%m/%d/%Y'),'{email}','{password}','{phone}','{gender}','fishfdlhgslkfghsfhsdl',{pincode})";
            try
            {
                MySqlCommand cmd = new(insertQuery, connection.conn);

                cmd.ExecuteNonQuery();
                //ReadKey();
            }
            catch (Exception e)
            {
                //WriteLine(e.Message);
                //ReadKey();
            }
        }

    }
}
