

using MySql.Data.MySqlClient;
using ShopManagementApplication.classes;
using ShopManagementApplication.database;
using ShopManagementApplication.screens.admin;
using ShopManagementApplication.screens.attendant;

namespace ShopManagementApplication.screens
{
    internal class LoginScreen : Form
    {
        private Button loginBtn;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextField;
        private TextBox usernameTextField;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label loginLabel;
        public static User user;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.usernameTextField = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(64, 303);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(251, 37);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.passwordLabel.Location = new System.Drawing.Point(64, 209);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 15);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.usernameLabel.Location = new System.Drawing.Point(64, 138);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 15);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordTextField
            // 
            this.passwordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextField.Location = new System.Drawing.Point(64, 230);
            this.passwordTextField.MinimumSize = new System.Drawing.Size(251, 32);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.Size = new System.Drawing.Size(251, 32);
            this.passwordTextField.TabIndex = 5;
            this.passwordTextField.UseSystemPasswordChar = true;
            // 
            // usernameTextField
            // 
            this.usernameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextField.Location = new System.Drawing.Point(64, 159);
            this.usernameTextField.MinimumSize = new System.Drawing.Size(251, 32);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.Size = new System.Drawing.Size(251, 32);
            this.usernameTextField.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.loginLabel.Location = new System.Drawing.Point(132, 72);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(112, 38);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.usernameTextField);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordTextField);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Location = new System.Drawing.Point(505, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 485);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.BackColor = Color.FromKnownColor(KnownColor.AliceBlue);
            this.ClientSize = new System.Drawing.Size(884, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new();
            string username = usernameTextField.Text;
            string password = passwordTextField.Text;
            string hashPassword = "";
            string role = "";
            string passwordQuery = $"Select password, role FROM users WHERE username = '{username}'";
            bool pass = false;

            MySqlCommand cmd = new(passwordQuery, connection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {

                if (reader.Read())
                {
                    hashPassword = reader.GetString(0).ToString();
                    role = reader.GetString(1).ToString();
                }

            }
            if (!string.IsNullOrEmpty(hashPassword))
            {
                pass = BCrypt.Net.BCrypt.Verify(password, hashPassword);
            }

            if (pass)
            {
                Hide();
                user = new(username, role);
                if (role == "Admin")
                {
                    AdminScreen admin = new();
                    admin.Tag = this;
                    admin.Show();
                }
                else
                {
                    AttendantScreen attendant = new();
                    attendant.Tag = this;
                    attendant.Show();
                }
            }
        }
    }
}
