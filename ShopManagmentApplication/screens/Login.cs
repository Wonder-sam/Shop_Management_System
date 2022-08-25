
using System.Data;
using MySql.Data.MySqlClient;
using ShopManagementApplication.database;
using ShopManagementApplication.screens.admin;
using ShopManagementApplication.screens.attendant;
using System.Runtime.InteropServices;

namespace ShopManagementApplication.screens
{
    internal class Login : Form
    {
        private TextBox passwordTextField;
        private TextBox usernameTextField;
        private Label loginLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private Button loginBtn;
        private Label closeBtn;
        private Panel panel1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundedRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Login()
        {
            InitializeComponent();
            this.panel1!.Region = Region.FromHrgn(CreateRoundedRectRgn(0, 0, this.panel1.Width, this.panel1.Height, 20, 20));
            this.usernameTextField.Focus();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.usernameTextField = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordTextField);
            this.panel1.Controls.Add(this.usernameTextField);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(143, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 381);
            this.panel1.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(69, 249);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(251, 37);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(69, 155);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 15);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameLabel.Location = new System.Drawing.Point(69, 84);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 15);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordTextField
            // 
            this.passwordTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextField.Location = new System.Drawing.Point(69, 176);
            this.passwordTextField.MinimumSize = new System.Drawing.Size(251, 30);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PlaceholderText = "Password";
            this.passwordTextField.Size = new System.Drawing.Size(251, 30);
            this.passwordTextField.TabIndex = 1;
            this.passwordTextField.UseSystemPasswordChar = true;
            // 
            // usernameTextField
            // 
            this.usernameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextField.Location = new System.Drawing.Point(69, 105);
            this.usernameTextField.MinimumSize = new System.Drawing.Size(251, 30);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.PlaceholderText = "Username";
            this.usernameTextField.Size = new System.Drawing.Size(251, 30);
            this.usernameTextField.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.loginLabel.Location = new System.Drawing.Point(137, 18);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(112, 38);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "LOGIN";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Location = new System.Drawing.Point(659, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.MaximumSize = new System.Drawing.Size(40, 40);
            this.closeBtn.MinimumSize = new System.Drawing.Size(30, 30);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_Enter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_Leave);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(689, 556);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new();
            string username = usernameTextField.Text;
            string password = passwordTextField.Text;
            string hashPassword ="";
            string role = "";
            string passwordQuery = $"Select password, role FROM users WHERE username = '{username}'";
            bool pass = true;

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

        private void closeBtn_Enter(object sender, EventArgs e)
        {
            this.closeBtn.BackColor = Color.Red;

        }
        private void closeBtn_Leave(object sender, EventArgs e)
        {
            this.closeBtn.BackColor = Color.Transparent;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            var login = (Login)Tag;
            login.Show();
        }

    }
}
