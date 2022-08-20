using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagementApp.screens.admin.manageUsers;

namespace ShopManagementApp.screens.admin
{
    public class AdminScreen : Form
    {
        public Panel panel1;
        private Panel manageUsersTab;
        private Label usersTabs;
        private TreeView sideTabs;
        private TreeNode treeNode1;
        private TreeNode treeNode2;
        private TreeNode expandUsers;
        private Label label1;
        private Panel updateUserPage;
        private Label label2;
        private TreeNode expandStocks;
        private Panel panel2;
        private Label deleteUserTopTab;
        private Label updateUserTopTab;
        private Label addUserTopTab;
        private Panel userBar;
        private Label username;
        private Label shopName;
        private AddUser addUserSubTab;
        private UpdateUser updateUserSubTab;
        private DeleteUser deleteUserSubTab;
        private UserControl[] tabs; 

        public AdminScreen()
        {
            InitializeComponent();
            tabs = new UserControl[] {addUserSubTab, updateUserSubTab, deleteUserSubTab};
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update User");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete User");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Manage Users", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Add Items");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Manage Stocks", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.addUserSubTab = new ShopManagementApp.screens.admin.manageUsers.AddUser();
            this.updateUserSubTab = new ShopManagementApp.screens.admin.manageUsers.UpdateUser();
            this.deleteUserSubTab = new ShopManagementApp.screens.admin.manageUsers.DeleteUser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.usersTabs = new System.Windows.Forms.Label();
            this.sideTabs = new System.Windows.Forms.TreeView();
            this.userBar = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.manageUsersTab = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteUserTopTab = new System.Windows.Forms.Label();
            this.updateUserTopTab = new System.Windows.Forms.Label();
            this.addUserTopTab = new System.Windows.Forms.Label();
            this.updateUserPage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.userBar.SuspendLayout();
            this.manageUsersTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.updateUserPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserSubTab
            // 
            this.addUserSubTab.BackColor = System.Drawing.Color.White;
            this.addUserSubTab.Location = new System.Drawing.Point(3, 57);
            this.addUserSubTab.Name = "addUserSubTab";
            this.addUserSubTab.Size = new System.Drawing.Size(691, 595);
            this.addUserSubTab.TabIndex = 0;
            // 
            // updateUserSubTab
            // 
            this.updateUserSubTab.BackColor = System.Drawing.Color.White;
            this.updateUserSubTab.Location = new System.Drawing.Point(3, 47);
            this.updateUserSubTab.Name = "updateUserSubTab";
            this.updateUserSubTab.Size = new System.Drawing.Size(689, 614);
            this.updateUserSubTab.TabIndex = 3;
            // 
            // deleteUserSubTab
            // 
            this.deleteUserSubTab.Location = new System.Drawing.Point(3, 51);
            this.deleteUserSubTab.Name = "deleteUserSubTab";
            this.deleteUserSubTab.Size = new System.Drawing.Size(691, 588);
            this.deleteUserSubTab.TabIndex = 0;
            this.deleteUserSubTab.BackColor = Color.White;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Controls.Add(this.usersTabs);
            this.panel1.Controls.Add(this.sideTabs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 629);
            this.panel1.TabIndex = 0;
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.BackColor = System.Drawing.Color.Transparent;
            this.shopName.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shopName.ForeColor = System.Drawing.Color.White;
            this.shopName.Location = new System.Drawing.Point(50, 21);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(138, 36);
            this.shopName.TabIndex = 2;
            this.shopName.Text = "Shoprite";
            // 
            // usersTabs
            // 
            this.usersTabs.AutoSize = true;
            this.usersTabs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersTabs.Location = new System.Drawing.Point(25, 59);
            this.usersTabs.Name = "usersTabs";
            this.usersTabs.Size = new System.Drawing.Size(0, 15);
            this.usersTabs.TabIndex = 0;
            this.usersTabs.Click += new System.EventHandler(this.UsersTabs_Click);
            // 
            // sideTabs
            // 
            this.sideTabs.BackColor = System.Drawing.Color.SteelBlue;
            this.sideTabs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sideTabs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sideTabs.FullRowSelect = true;
            this.sideTabs.ItemHeight = 30;
            this.sideTabs.Location = new System.Drawing.Point(34, 88);
            this.sideTabs.Name = "sideTabs";
            treeNode1.ForeColor = System.Drawing.Color.White;
            treeNode1.Name = "addUser";
            treeNode1.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Add User";
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.Name = "updateUser";
            treeNode2.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Update User";
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.Name = "deleteUser";
            treeNode3.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Delete User";
            treeNode4.ForeColor = System.Drawing.Color.White;
            treeNode4.Name = "userManager";
            treeNode4.NodeFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Manage Users";
            treeNode5.ForeColor = System.Drawing.Color.White;
            treeNode5.Name = "addItems";
            treeNode5.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Add Items";
            treeNode6.ForeColor = System.Drawing.Color.White;
            treeNode6.Name = "manageStocks";
            treeNode6.NodeFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Manage Stocks";
            this.sideTabs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            this.sideTabs.Scrollable = false;
            this.sideTabs.ShowLines = false;
            this.sideTabs.Size = new System.Drawing.Size(201, 179);
            this.sideTabs.TabIndex = 1;
            this.sideTabs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SideTabs_AfterSelect);
            // 
            // userBar
            // 
            this.userBar.BackColor = System.Drawing.Color.SteelBlue;
            this.userBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userBar.Controls.Add(this.username);
            this.userBar.Location = new System.Drawing.Point(242, 0);
            this.userBar.Name = "userBar";
            this.userBar.Size = new System.Drawing.Size(713, 90);
            this.userBar.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(144, 38);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(49, 15);
            this.username.TabIndex = 2;
            this.username.Text = "Wonder";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // manageUsersTab
            // 
            this.manageUsersTab.AutoScroll = true;
            this.manageUsersTab.Controls.Add(this.panel2);
            this.manageUsersTab.Controls.Add(this.addUserSubTab);
            this.manageUsersTab.Controls.Add(this.updateUserSubTab);
            this.manageUsersTab.Controls.Add(this.deleteUserSubTab);
            this.manageUsersTab.Location = new System.Drawing.Point(242, 89);
            this.manageUsersTab.Name = "manageUsersTab";
            this.manageUsersTab.Size = new System.Drawing.Size(713, 540);
            this.manageUsersTab.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.deleteUserTopTab);
            this.panel2.Controls.Add(this.updateUserTopTab);
            this.panel2.Controls.Add(this.addUserTopTab);
            this.panel2.Location = new System.Drawing.Point(3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 61);
            this.panel2.TabIndex = 2;
            // 
            // deleteUserTopTab
            // 
            this.deleteUserTopTab.AutoSize = true;
            this.deleteUserTopTab.BackColor = System.Drawing.Color.Transparent;
            this.deleteUserTopTab.Location = new System.Drawing.Point(400, 19);
            this.deleteUserTopTab.Name = "deleteUserTopTab";
            this.deleteUserTopTab.Size = new System.Drawing.Size(66, 15);
            this.deleteUserTopTab.TabIndex = 0;
            this.deleteUserTopTab.Text = "Delete User";
            // 
            // updateUserTopTab
            // 
            this.updateUserTopTab.AutoSize = true;
            this.updateUserTopTab.BackColor = System.Drawing.Color.Transparent;
            this.updateUserTopTab.Location = new System.Drawing.Point(295, 19);
            this.updateUserTopTab.Name = "updateUserTopTab";
            this.updateUserTopTab.Size = new System.Drawing.Size(71, 15);
            this.updateUserTopTab.TabIndex = 0;
            this.updateUserTopTab.Text = "Update User";
            // 
            // addUserTopTab
            // 
            this.addUserTopTab.AutoSize = true;
            this.addUserTopTab.BackColor = System.Drawing.Color.Transparent;
            this.addUserTopTab.Location = new System.Drawing.Point(201, 19);
            this.addUserTopTab.Name = "addUserTopTab";
            this.addUserTopTab.Size = new System.Drawing.Size(55, 15);
            this.addUserTopTab.TabIndex = 0;
            this.addUserTopTab.Text = "Add User";
            // 
            // updateUserPage
            // 
            this.updateUserPage.Controls.Add(this.label2);
            this.updateUserPage.Location = new System.Drawing.Point(0, 0);
            this.updateUserPage.Name = "updateUserPage";
            this.updateUserPage.Size = new System.Drawing.Size(695, 571);
            this.updateUserPage.TabIndex = 2;
            this.updateUserPage.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "updateUserPage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "add user";
            // 
            // AdminScreen
            // 
            this.ClientSize = new System.Drawing.Size(955, 629);
            this.Controls.Add(this.userBar);
            this.Controls.Add(this.manageUsersTab);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userBar.ResumeLayout(false);
            this.userBar.PerformLayout();
            this.manageUsersTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.updateUserPage.ResumeLayout(false);
            this.updateUserPage.PerformLayout();
            this.ResumeLayout(false);

        }

        private void UsersTabs_Click(object sender, EventArgs e)
        {
            expandUsers.Expand();
        }

        private void Stocks_Click(object sender, EventArgs e)
        {
            expandStocks.Expand();
        }

        private void SideTabs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for(int t=0;t<3;t++)
            {
                tabs[t].Visible = false;
            }
            if(e.Node!.Name == "userManager" || e.Node.Name == "addUser")
            {
                manageUsersTab.Visible = true;
                addUserSubTab.Visible = true;
                //updateUserSubTab.Visible = false;
            }
            else if(e.Node.Name == "updateUser")
            {
                //addUserSubTab.Visible = false;
                updateUserSubTab.Visible = true;
            }
            else if(e.Node.Name == "deleteUser")
            {
                deleteUserSubTab.Visible = true;
            }
            else if (e.Node.Name == "manageStocks")
            {
                manageUsersTab.Visible = false;
                updateUserPage.Visible = true;
            }
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
