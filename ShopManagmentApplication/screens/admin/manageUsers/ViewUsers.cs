using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens.admin.manageUsers
{
    internal class ViewUsers : UserControl
    {
        private Label lastnameHeader;
        private Label firstnameHeader;
        private Label usernameHead;
        private Label gender;
        private Label emailHeader;
        private Label label5;
        private Label roleHeader;
        private Label phoneHeader;
        private TableLayoutPanel usersTable;

        public ViewUsers()
        {
            InitializeComponent();
            User.ViewUsers(usersTable);
        }

        private void InitializeComponent()
        {
            this.usersTable = new System.Windows.Forms.TableLayoutPanel();
            this.lastnameHeader = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstnameHeader = new System.Windows.Forms.Label();
            this.roleHeader = new System.Windows.Forms.Label();
            this.usernameHead = new System.Windows.Forms.Label();
            this.emailHeader = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.phoneHeader = new System.Windows.Forms.Label();
            this.usersTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.AutoSize = true;
            this.usersTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.usersTable.ColumnCount = 8;
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.Controls.Add(this.lastnameHeader, 0, 0);
            this.usersTable.Controls.Add(this.label5, 5, 0);
            this.usersTable.Controls.Add(this.firstnameHeader, 1, 0);
            this.usersTable.Controls.Add(this.roleHeader, 6, 0);
            this.usersTable.Controls.Add(this.usernameHead, 2, 0);
            this.usersTable.Controls.Add(this.emailHeader, 3, 0);
            this.usersTable.Controls.Add(this.gender, 4, 0);
            this.usersTable.Controls.Add(this.phoneHeader, 7, 0);
            this.usersTable.Location = new System.Drawing.Point(44, 69);
            this.usersTable.Name = "usersTable";
            this.usersTable.RowCount = 1;
            this.usersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.usersTable.Size = new System.Drawing.Size(501, 54);
            this.usersTable.TabIndex = 0;
            // 
            // lastnameHeader
            // 
            this.lastnameHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnameHeader.AutoSize = true;
            this.lastnameHeader.Location = new System.Drawing.Point(4, 1);
            this.lastnameHeader.Name = "lastnameHeader";
            this.lastnameHeader.Size = new System.Drawing.Size(63, 52);
            this.lastnameHeader.TabIndex = 0;
            this.lastnameHeader.Text = "Last Name";
            this.lastnameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 52);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstnameHeader
            // 
            this.firstnameHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameHeader.AutoSize = true;
            this.firstnameHeader.Location = new System.Drawing.Point(74, 1);
            this.firstnameHeader.MaximumSize = new System.Drawing.Size(80, 0);
            this.firstnameHeader.Name = "firstnameHeader";
            this.firstnameHeader.Size = new System.Drawing.Size(64, 52);
            this.firstnameHeader.TabIndex = 1;
            this.firstnameHeader.Text = "First Name";
            this.firstnameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleHeader
            // 
            this.roleHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleHeader.AutoSize = true;
            this.roleHeader.Location = new System.Drawing.Point(387, 1);
            this.roleHeader.Name = "roleHeader";
            this.roleHeader.Size = new System.Drawing.Size(30, 52);
            this.roleHeader.TabIndex = 6;
            this.roleHeader.Text = "Role";
            this.roleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameHead
            // 
            this.usernameHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameHead.AutoSize = true;
            this.usernameHead.Location = new System.Drawing.Point(145, 1);
            this.usernameHead.Name = "usernameHead";
            this.usernameHead.Size = new System.Drawing.Size(60, 52);
            this.usernameHead.TabIndex = 2;
            this.usernameHead.Text = "Username";
            this.usernameHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailHeader
            // 
            this.emailHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailHeader.AutoSize = true;
            this.emailHeader.Location = new System.Drawing.Point(212, 1);
            this.emailHeader.Name = "emailHeader";
            this.emailHeader.Size = new System.Drawing.Size(36, 52);
            this.emailHeader.TabIndex = 4;
            this.emailHeader.Text = "Email";
            this.emailHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gender
            // 
            this.gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(255, 1);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(45, 52);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender";
            this.gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneHeader
            // 
            this.phoneHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneHeader.AutoSize = true;
            this.phoneHeader.Location = new System.Drawing.Point(424, 1);
            this.phoneHeader.Name = "phoneHeader";
            this.phoneHeader.Size = new System.Drawing.Size(73, 52);
            this.phoneHeader.TabIndex = 8;
            this.phoneHeader.Text = "Phone";
            this.phoneHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewUsers
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usersTable);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(951, 602);
            this.usersTable.ResumeLayout(false);
            this.usersTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
