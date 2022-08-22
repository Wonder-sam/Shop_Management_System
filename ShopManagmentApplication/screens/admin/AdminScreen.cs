using System.Windows.Forms;
using ShopManagementApplication.screens.admin.manageProducts;
using ShopManagementApplication.screens.admin.manageUsers;

namespace ShopManagementApplication.screens.admin
{
    public class AdminScreen : Form
    {
        public Panel panel1;
        private Panel manageUsersTab;
        private Label usersTabs;
        private TreeView sideTabs;
        private Label label1;
        private Panel manageProductsPage;
        private Label label2;
        private Panel userTopSubTabs;
        private Panel productTopSubTabs;
        private Panel userBar;
        private Label username;
        private Label shopName;
        private AddUser addUserSubTab;
        private UpdateUser updateUserSubTab;
        private DeleteUser deleteUserSubTab;
        private ViewUsers viewUsersSubTab;
        private AddProduct addProductSubTab;
        private UpdateProduct updateProductSubTab;
        private DeleteProduct removeProductSubTab;
        private Label removeProduct;
        private Label updateProduct;
        private Label addProduct;
        private Label addUser;
        private Label updateUser;
        private Label viewUsers;
        private Label removeUser;
        private AddProduct addProduct1;
        private UserControl[] tabs; 

        public AdminScreen()
        {
            InitializeComponent();
            sideTabs.ExpandAll();
            this.viewUsersSubTab = new ShopManagementApplication.screens.admin.manageUsers.ViewUsers();
            this.manageUsersTab.Controls.Add(viewUsersSubTab);

            

            tabs = new UserControl[] {addUserSubTab, updateUserSubTab, deleteUserSubTab, viewUsersSubTab, 
                addProductSubTab, removeProductSubTab};
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update User");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete User");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("View Users");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Manage Users", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Manage Categories");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Add Product");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Update Product");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Delete Product");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Manage Products", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.addUserSubTab = new ShopManagementApplication.screens.admin.manageUsers.AddUser();
            this.updateUserSubTab = new ShopManagementApplication.screens.admin.manageUsers.UpdateUser();
            this.deleteUserSubTab = new ShopManagementApplication.screens.admin.manageUsers.DeleteUser();
            this.addProductSubTab = new ShopManagementApplication.screens.admin.manageProducts.AddProduct();
            this.updateProductSubTab = new ShopManagementApplication.screens.admin.manageProducts.UpdateProduct();
            this.removeProductSubTab = new ShopManagementApplication.screens.admin.manageProducts.DeleteProduct();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.usersTabs = new System.Windows.Forms.Label();
            this.sideTabs = new System.Windows.Forms.TreeView();
            this.userBar = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.manageUsersTab = new System.Windows.Forms.Panel();
            this.userTopSubTabs = new System.Windows.Forms.Panel();
            this.updateUser = new System.Windows.Forms.Label();
            this.viewUsers = new System.Windows.Forms.Label();
            this.removeUser = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Label();
            this.productTopSubTabs = new System.Windows.Forms.Panel();
            this.removeProduct = new System.Windows.Forms.Label();
            this.updateProduct = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Label();
            this.manageProductsPage = new System.Windows.Forms.Panel();
            this.addProduct1 = new ShopManagementApplication.screens.admin.manageProducts.AddProduct();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.userBar.SuspendLayout();
            this.manageUsersTab.SuspendLayout();
            this.userTopSubTabs.SuspendLayout();
            this.productTopSubTabs.SuspendLayout();
            this.manageProductsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserSubTab
            // 
            this.addUserSubTab.BackColor = System.Drawing.Color.White;
            this.addUserSubTab.Location = new System.Drawing.Point(3, 57);
            this.addUserSubTab.Name = "addUserSubTab";
            this.addUserSubTab.Size = new System.Drawing.Size(807, 595);
            this.addUserSubTab.TabIndex = 0;
            // 
            // updateUserSubTab
            // 
            this.updateUserSubTab.BackColor = System.Drawing.Color.White;
            this.updateUserSubTab.Location = new System.Drawing.Point(3, 47);
            this.updateUserSubTab.Name = "updateUserSubTab";
            this.updateUserSubTab.Size = new System.Drawing.Size(807, 614);
            this.updateUserSubTab.TabIndex = 3;
            // 
            // deleteUserSubTab
            // 
            this.deleteUserSubTab.BackColor = System.Drawing.Color.White;
            this.deleteUserSubTab.Location = new System.Drawing.Point(3, 51);
            this.deleteUserSubTab.Name = "deleteUserSubTab";
            this.deleteUserSubTab.Size = new System.Drawing.Size(807, 588);
            this.deleteUserSubTab.TabIndex = 0;
            // 
            // addProductSubTab
            // 
            this.addProductSubTab.BackColor = System.Drawing.Color.White;
            this.addProductSubTab.Location = new System.Drawing.Point(0, 51);
            this.addProductSubTab.Margin = new System.Windows.Forms.Padding(0);
            this.addProductSubTab.Name = "addProductSubTab";
            this.addProductSubTab.Size = new System.Drawing.Size(811, 668);
            this.addProductSubTab.TabIndex = 0;
            // 
            // updateProductSubTab
            // 
            this.updateProductSubTab.BackColor = System.Drawing.Color.White;
            this.updateProductSubTab.Location = new System.Drawing.Point(0, 51);
            this.updateProductSubTab.Name = "updateProductSubTab";
            this.updateProductSubTab.Size = new System.Drawing.Size(811, 668);
            this.updateProductSubTab.TabIndex = 0;
            // 
            // removeProductSubTab
            // 
            this.removeProductSubTab.BackColor = System.Drawing.Color.White;
            this.removeProductSubTab.Location = new System.Drawing.Point(0, 51);
            this.removeProductSubTab.Name = "removeProductSubTab";
            this.removeProductSubTab.Size = new System.Drawing.Size(811, 668);
            this.removeProductSubTab.TabIndex = 0;
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
            // 
            // sideTabs
            // 
            this.sideTabs.BackColor = System.Drawing.Color.SteelBlue;
            this.sideTabs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sideTabs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sideTabs.FullRowSelect = true;
            this.sideTabs.ItemHeight = 30;
            this.sideTabs.Location = new System.Drawing.Point(40, 88);
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
            treeNode4.Name = "viewUsers";
            treeNode4.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "View Users";
            treeNode5.ForeColor = System.Drawing.Color.White;
            treeNode5.Name = "userManager";
            treeNode5.NodeFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Manage Users";
            treeNode6.ForeColor = System.Drawing.Color.White;
            treeNode6.Name = "manageCategories";
            treeNode6.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Manage Categories";
            treeNode7.ForeColor = System.Drawing.Color.White;
            treeNode7.Name = "addProduct";
            treeNode7.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "Add Product";
            treeNode8.ForeColor = System.Drawing.Color.White;
            treeNode8.Name = "updateProduct";
            treeNode8.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "Update Product";
            treeNode9.ForeColor = System.Drawing.Color.White;
            treeNode9.Name = "deleteProduct";
            treeNode9.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "Delete Product";
            treeNode10.ForeColor = System.Drawing.Color.White;
            treeNode10.Name = "manageProducts";
            treeNode10.NodeFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "Manage Products";
            this.sideTabs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.sideTabs.Scrollable = false;
            this.sideTabs.ShowLines = false;
            this.sideTabs.Size = new System.Drawing.Size(201, 528);
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
            this.userBar.Size = new System.Drawing.Size(830, 90);
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
            this.manageUsersTab.Controls.Add(this.userTopSubTabs);
            this.manageUsersTab.Controls.Add(this.addUserSubTab);
            this.manageUsersTab.Controls.Add(this.updateUserSubTab);
            this.manageUsersTab.Controls.Add(this.deleteUserSubTab);
            this.manageUsersTab.Location = new System.Drawing.Point(242, 89);
            this.manageUsersTab.Name = "manageUsersTab";
            this.manageUsersTab.Size = new System.Drawing.Size(830, 540);
            this.manageUsersTab.TabIndex = 1;
            // 
            // userTopSubTabs
            // 
            this.userTopSubTabs.BackColor = System.Drawing.Color.White;
            this.userTopSubTabs.Controls.Add(this.updateUser);
            this.userTopSubTabs.Controls.Add(this.viewUsers);
            this.userTopSubTabs.Controls.Add(this.removeUser);
            this.userTopSubTabs.Controls.Add(this.addUser);
            this.userTopSubTabs.Location = new System.Drawing.Point(3, -1);
            this.userTopSubTabs.Name = "userTopSubTabs";
            this.userTopSubTabs.Size = new System.Drawing.Size(807, 61);
            this.userTopSubTabs.TabIndex = 2;
            // 
            // updateUser
            // 
            this.updateUser.AutoSize = true;
            this.updateUser.Location = new System.Drawing.Point(262, 25);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(71, 15);
            this.updateUser.TabIndex = 0;
            this.updateUser.Text = "Update User";
            // 
            // viewUsers
            // 
            this.viewUsers.AutoSize = true;
            this.viewUsers.Location = new System.Drawing.Point(490, 25);
            this.viewUsers.Name = "viewUsers";
            this.viewUsers.Size = new System.Drawing.Size(63, 15);
            this.viewUsers.TabIndex = 0;
            this.viewUsers.Text = "View Users";
            // 
            // removeUser
            // 
            this.removeUser.AutoSize = true;
            this.removeUser.Location = new System.Drawing.Point(378, 25);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(76, 15);
            this.removeUser.TabIndex = 0;
            this.removeUser.Text = "Remove User";
            this.removeUser.Click += new System.EventHandler(this.label3_Click);
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Location = new System.Drawing.Point(148, 25);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(55, 15);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Add User";
            // 
            // productTopSubTabs
            // 
            this.productTopSubTabs.BackColor = System.Drawing.Color.White;
            this.productTopSubTabs.Controls.Add(this.addProduct);
            this.productTopSubTabs.Controls.Add(this.updateProduct);
            this.productTopSubTabs.Controls.Add(this.removeProduct);
            this.productTopSubTabs.Location = new System.Drawing.Point(0, -1);
            this.productTopSubTabs.Name = "productTopSubTabs";
            this.productTopSubTabs.Size = new System.Drawing.Size(811, 61);
            this.productTopSubTabs.TabIndex = 2;
            // 
            // removeProduct
            // 
            this.removeProduct.AutoSize = true;
            this.removeProduct.Location = new System.Drawing.Point(402, 25);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(95, 15);
            this.removeProduct.TabIndex = 0;
            this.removeProduct.Text = "Remove Product";
            // 
            // updateProduct
            // 
            this.updateProduct.AutoSize = true;
            this.updateProduct.Location = new System.Drawing.Point(283, 25);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(90, 15);
            this.updateProduct.TabIndex = 0;
            this.updateProduct.Text = "Update Product";
            this.updateProduct.Click += new System.EventHandler(this.label4_Click);
            // 
            // addProduct
            // 
            this.addProduct.AutoSize = true;
            this.addProduct.Location = new System.Drawing.Point(172, 25);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(74, 15);
            this.addProduct.TabIndex = 0;
            this.addProduct.Text = "Add Product";
            // 
            // manageProductsPage
            // 
            this.manageProductsPage.AutoScroll = true;
            this.manageProductsPage.BackColor = System.Drawing.Color.IndianRed;
            this.manageProductsPage.Controls.Add(this.addProduct1);
            this.manageProductsPage.Controls.Add(this.productTopSubTabs);
            this.manageProductsPage.Controls.Add(this.addProductSubTab);
            this.manageProductsPage.Controls.Add(this.updateProductSubTab);
            this.manageProductsPage.Controls.Add(this.removeProductSubTab);
            this.manageProductsPage.Location = new System.Drawing.Point(244, 89);
            this.manageProductsPage.Name = "manageProductsPage";
            this.manageProductsPage.Size = new System.Drawing.Size(828, 540);
            this.manageProductsPage.TabIndex = 2;
            this.manageProductsPage.Visible = false;
            // 
            // addProduct1
            // 
            this.addProduct1.BackColor = System.Drawing.Color.White;
            this.addProduct1.Location = new System.Drawing.Point(-2, 49);
            this.addProduct1.Margin = new System.Windows.Forms.Padding(0);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(830, 668);
            this.addProduct1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "manageProductsPage";
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 629);
            this.Controls.Add(this.userBar);
            this.Controls.Add(this.manageUsersTab);
            this.Controls.Add(this.manageProductsPage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userBar.ResumeLayout(false);
            this.userBar.PerformLayout();
            this.manageUsersTab.ResumeLayout(false);
            this.userTopSubTabs.ResumeLayout(false);
            this.userTopSubTabs.PerformLayout();
            this.productTopSubTabs.ResumeLayout(false);
            this.productTopSubTabs.PerformLayout();
            this.manageProductsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SideTabs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for(int t=0;t<tabs.Length;t++)
            {

                tabs[t].SendToBack();
                tabs[t].Visible = false;
            }
            if(e.Node!.Name == "userManager" || e.Node.Name == "addUser")
            {
                manageProductsPage.Visible = false;
                manageUsersTab.Visible = true;
                addUserSubTab.Visible = true;
            }
            else if(e.Node.Name == "updateUser")
            {
                manageProductsPage.Visible = false;
                manageUsersTab.Visible = true;
                updateUserSubTab.Visible = true;
            }
            else if(e.Node.Name == "deleteUser")
            {
                manageProductsPage.Visible = false;
                manageUsersTab.Visible = true;
                deleteUserSubTab.Visible = true;
            }
            else if (e.Node.Name == "viewUsers")
            {
                manageProductsPage.Visible = false;
                manageUsersTab.Visible = true;
                viewUsersSubTab.Visible = true;
            }
            else if (e.Node.Name == "manageProducts" || e.Node.Name == "addProduct")
            {
                manageUsersTab.Visible = false;
                manageProductsPage.Visible = true;
                addProductSubTab.Visible = true;
            }
            else if (e.Node.Name == "updateProduct")
            {
                manageUsersTab.Visible = false;
                manageProductsPage.Visible = true;
                updateProductSubTab.Visible = true;
                updateProductSubTab.BringToFront();
            }
            else if (e.Node.Name == "deleteProduct")
            {
                manageUsersTab.Visible = false;
                manageProductsPage.Visible = true;
                removeProductSubTab.Visible = true;
                removeProductSubTab.BringToFront();
            }
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
