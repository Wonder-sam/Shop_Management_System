﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens.admin.manageUsers
{
    internal class DeleteUser : UserControl
    {
        private GroupBox findUserGroup;
        private TextBox usernameTextField;
        private Button searchBtn;
        private GroupBox foundUserGroup;
        private Label genderLabel;
        private Label roleLabel;
        private Label dobLabel;
        private Label phoneLabel;
        private Label foundUsernameLabel;
        private Label emailLable;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailText;
        private Label usernameText;
        private Label genderText;
        private Label dobText;
        private Label phoneText;
        private Label firstNameText;
        private Label lastNameText;
        private Label roleText;
        private Button deleteBtn;
        private Label deleteUserHeader;
        private Label usernameLabel;

        public DeleteUser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.findUserGroup = new System.Windows.Forms.GroupBox();
            this.usernameTextField = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.foundUserGroup = new System.Windows.Forms.GroupBox();
            this.emailText = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.roleText = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.Label();
            this.dobText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.foundUsernameLabel = new System.Windows.Forms.Label();
            this.emailLable = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteUserHeader = new System.Windows.Forms.Label();
            this.findUserGroup.SuspendLayout();
            this.foundUserGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // findUserGroup
            // 
            this.findUserGroup.Controls.Add(this.usernameTextField);
            this.findUserGroup.Controls.Add(this.searchBtn);
            this.findUserGroup.Controls.Add(this.usernameLabel);
            this.findUserGroup.Location = new System.Drawing.Point(113, 67);
            this.findUserGroup.Name = "findUserGroup";
            this.findUserGroup.Size = new System.Drawing.Size(450, 92);
            this.findUserGroup.TabIndex = 5;
            this.findUserGroup.TabStop = false;
            this.findUserGroup.Text = "Find User";
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
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(244, 49);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(143, 32);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(20, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // foundUserGroup
            // 
            this.foundUserGroup.Controls.Add(this.emailText);
            this.foundUserGroup.Controls.Add(this.usernameText);
            this.foundUserGroup.Controls.Add(this.roleText);
            this.foundUserGroup.Controls.Add(this.genderText);
            this.foundUserGroup.Controls.Add(this.dobText);
            this.foundUserGroup.Controls.Add(this.phoneText);
            this.foundUserGroup.Controls.Add(this.firstNameText);
            this.foundUserGroup.Controls.Add(this.lastNameText);
            this.foundUserGroup.Controls.Add(this.genderLabel);
            this.foundUserGroup.Controls.Add(this.roleLabel);
            this.foundUserGroup.Controls.Add(this.dobLabel);
            this.foundUserGroup.Controls.Add(this.phoneLabel);
            this.foundUserGroup.Controls.Add(this.foundUsernameLabel);
            this.foundUserGroup.Controls.Add(this.emailLable);
            this.foundUserGroup.Controls.Add(this.firstNameLabel);
            this.foundUserGroup.Controls.Add(this.lastNameLabel);
            this.foundUserGroup.Location = new System.Drawing.Point(113, 169);
            this.foundUserGroup.Name = "foundUserGroup";
            this.foundUserGroup.Size = new System.Drawing.Size(450, 225);
            this.foundUserGroup.TabIndex = 6;
            this.foundUserGroup.TabStop = false;
            this.foundUserGroup.Text = "Found User";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(108, 75);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(25, 15);
            this.emailText.TabIndex = 2;
            this.emailText.Text = "......";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Location = new System.Drawing.Point(108, 119);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(25, 15);
            this.usernameText.TabIndex = 2;
            this.usernameText.Text = "......";
            // 
            // roleText
            // 
            this.roleText.AutoSize = true;
            this.roleText.Location = new System.Drawing.Point(323, 162);
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(25, 15);
            this.roleText.TabIndex = 2;
            this.roleText.Text = "......";
            // 
            // genderText
            // 
            this.genderText.AutoSize = true;
            this.genderText.Location = new System.Drawing.Point(108, 162);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(25, 15);
            this.genderText.TabIndex = 2;
            this.genderText.Text = "......";
            // 
            // dobText
            // 
            this.dobText.AutoSize = true;
            this.dobText.Location = new System.Drawing.Point(322, 119);
            this.dobText.Name = "dobText";
            this.dobText.Size = new System.Drawing.Size(25, 15);
            this.dobText.TabIndex = 2;
            this.dobText.Text = "......";
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Location = new System.Drawing.Point(322, 75);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(25, 15);
            this.phoneText.TabIndex = 2;
            this.phoneText.Text = "......";
            // 
            // firstNameText
            // 
            this.firstNameText.AutoSize = true;
            this.firstNameText.Location = new System.Drawing.Point(322, 32);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(25, 15);
            this.firstNameText.TabIndex = 2;
            this.firstNameText.Text = "......";
            // 
            // lastNameText
            // 
            this.lastNameText.AutoSize = true;
            this.lastNameText.Location = new System.Drawing.Point(108, 32);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(25, 15);
            this.lastNameText.TabIndex = 2;
            this.lastNameText.Text = "......";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(20, 162);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 15);
            this.genderLabel.TabIndex = 1;
            this.genderLabel.Text = "Gender:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roleLabel.Location = new System.Drawing.Point(229, 162);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 15);
            this.roleLabel.TabIndex = 1;
            this.roleLabel.Text = "Role:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dobLabel.Location = new System.Drawing.Point(229, 119);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(73, 15);
            this.dobLabel.TabIndex = 1;
            this.dobLabel.Text = "Date of Birth";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(229, 75);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(44, 15);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "Phone:";
            // 
            // foundUsernameLabel
            // 
            this.foundUsernameLabel.AutoSize = true;
            this.foundUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foundUsernameLabel.Location = new System.Drawing.Point(20, 119);
            this.foundUsernameLabel.Name = "foundUsernameLabel";
            this.foundUsernameLabel.Size = new System.Drawing.Size(63, 15);
            this.foundUsernameLabel.TabIndex = 1;
            this.foundUsernameLabel.Text = "Username:";
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLable.Location = new System.Drawing.Point(20, 75);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(39, 15);
            this.emailLable.TabIndex = 1;
            this.emailLable.Text = "Email:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(229, 32);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(20, 32);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(221, 428);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(213, 42);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deleteUserHeader
            // 
            this.deleteUserHeader.AutoSize = true;
            this.deleteUserHeader.BackColor = System.Drawing.Color.Transparent;
            this.deleteUserHeader.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteUserHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteUserHeader.Location = new System.Drawing.Point(113, 22);
            this.deleteUserHeader.Name = "deleteUserHeader";
            this.deleteUserHeader.Size = new System.Drawing.Size(155, 28);
            this.deleteUserHeader.TabIndex = 8;
            this.deleteUserHeader.Text = "Delete User";
            // 
            // DeleteUser
            // 
            this.Controls.Add(this.deleteUserHeader);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.foundUserGroup);
            this.Controls.Add(this.findUserGroup);
            this.Name = "DeleteUser";
            this.Size = new System.Drawing.Size(951, 588);
            this.findUserGroup.ResumeLayout(false);
            this.findUserGroup.PerformLayout();
            this.foundUserGroup.ResumeLayout(false);
            this.foundUserGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextField.Text;
            User targetUser = User.GetUser(username)!;
            if (targetUser == null)
            {
                MessageBox.Show("User doesnt exist");
            }
            else
            {
                firstNameText.Text = targetUser.FirstNames;
                lastNameText.Text = targetUser.LastName;
                usernameTextField.Text = targetUser.Username;
                genderText.Text = targetUser.Gender;
                roleText.Text = targetUser.Role;
                emailText.Text = targetUser.Email;
                dobText.Text = targetUser.Dob.ToString();
                phoneText.Text = targetUser.Phone;
            }

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextField.Text;
            User.RemoveUser(username);
        }

    }
}
