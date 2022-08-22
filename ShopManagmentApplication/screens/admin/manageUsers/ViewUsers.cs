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
        private Label nameHeader;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TableLayoutPanel usersTable;

        public ViewUsers()
        {
            InitializeComponent();
            User.ViewUsers(usersTable);
        }

        private void InitializeComponent()
        {
            this.usersTable = new System.Windows.Forms.TableLayoutPanel();
            this.nameHeader = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usersTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.AutoSize = true;
            this.usersTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.usersTable.ColumnCount = 7;
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usersTable.Controls.Add(this.nameHeader, 0, 0);
            this.usersTable.Controls.Add(this.label5, 5, 0);
            this.usersTable.Controls.Add(this.label1, 1, 0);
            this.usersTable.Controls.Add(this.label6, 6, 0);
            this.usersTable.Controls.Add(this.label2, 2, 0);
            this.usersTable.Controls.Add(this.label4, 3, 0);
            this.usersTable.Controls.Add(this.label3, 4, 0);
            this.usersTable.Location = new System.Drawing.Point(44, 69);
            this.usersTable.Name = "usersTable";
            this.usersTable.RowCount = 1;
            this.usersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.usersTable.Size = new System.Drawing.Size(378, 54);
            this.usersTable.TabIndex = 0;
            // 
            // nameHeader
            // 
            this.nameHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameHeader.AutoSize = true;
            this.nameHeader.Location = new System.Drawing.Point(4, 1);
            this.nameHeader.Name = "nameHeader";
            this.nameHeader.Size = new System.Drawing.Size(39, 52);
            this.nameHeader.TabIndex = 0;
            this.nameHeader.Text = "Name";
            this.nameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 52);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date of Birth";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 1);
            this.label1.MaximumSize = new System.Drawing.Size(80, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 52);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pincode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 52);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewUsers
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.usersTable);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(807, 428);
            this.usersTable.ResumeLayout(false);
            this.usersTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
