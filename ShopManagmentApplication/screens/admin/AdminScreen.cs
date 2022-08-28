using System.Windows.Forms;
using ShopManagementApplication.classes;
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
        private Panel userBar;
        private Label username;
        private Label shopName;
        private AddUser addUserSubTab;
        private UpdateUser updateUserSubTab;
        private DeleteUser deleteUserSubTab;
        private readonly ViewUsers viewUsersSubTab;
        private AddProduct addProductSubTab;
        private UpdateProduct updateProductSubTab;
        private DeleteProduct removeProductSubTab;
        private ManageCategory manageCategorySubTab;
        private ViewProducts viewProductsSubTab;
        private Label removeProduct;
        private Label updateProduct;
        private Label addProduct;
        private PictureBox pictureBox1;
        private Button button1;
        private UserControl[] tabs; 

        public AdminScreen()
        {
            InitializeComponent();
            sideTabs!.ExpandAll();
            this.viewUsersSubTab = new()
            {
                Location = new System.Drawing.Point(0, 0)
            };
            this.manageUsersTab!.Controls.Add(viewUsersSubTab);
            this.viewProductsSubTab = new()
            {
                Location = new Point(0, 0)
            };
            this.manageProductsPage!.Controls.Add(viewProductsSubTab);
            this.username.Text = LoginScreen.user.Username;
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("View Products");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Manage Products", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.addUserSubTab = new ShopManagementApplication.screens.admin.manageUsers.AddUser();
            this.updateUserSubTab = new ShopManagementApplication.screens.admin.manageUsers.UpdateUser();
            this.deleteUserSubTab = new ShopManagementApplication.screens.admin.manageUsers.DeleteUser();
            this.updateProductSubTab = new ShopManagementApplication.screens.admin.manageProducts.UpdateProduct();
            this.removeProductSubTab = new ShopManagementApplication.screens.admin.manageProducts.DeleteProduct();
            this.manageCategorySubTab = new ShopManagementApplication.screens.admin.manageProducts.ManageCategory();
            this.addProductSubTab = new ShopManagementApplication.screens.admin.manageProducts.AddProduct();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopName = new System.Windows.Forms.Label();
            this.usersTabs = new System.Windows.Forms.Label();
            this.sideTabs = new System.Windows.Forms.TreeView();
            this.userBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.manageUsersTab = new System.Windows.Forms.Panel();
            this.addProduct = new System.Windows.Forms.Label();
            this.updateProduct = new System.Windows.Forms.Label();
            this.removeProduct = new System.Windows.Forms.Label();
            this.manageProductsPage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.userBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.manageUsersTab.SuspendLayout();
            this.manageProductsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserSubTab
            // 
            this.addUserSubTab.BackColor = System.Drawing.Color.White;
            this.addUserSubTab.Location = new System.Drawing.Point(0, 0);
            this.addUserSubTab.Name = "addUserSubTab";
            this.addUserSubTab.Size = new System.Drawing.Size(951, 595);
            this.addUserSubTab.TabIndex = 0;
            // 
            // updateUserSubTab
            // 
            this.updateUserSubTab.BackColor = System.Drawing.Color.White;
            this.updateUserSubTab.Location = new System.Drawing.Point(0, 0);
            this.updateUserSubTab.Name = "updateUserSubTab";
            this.updateUserSubTab.Size = new System.Drawing.Size(951, 614);
            this.updateUserSubTab.TabIndex = 3;
            // 
            // deleteUserSubTab
            // 
            this.deleteUserSubTab.BackColor = System.Drawing.Color.White;
            this.deleteUserSubTab.Location = new System.Drawing.Point(0, 0);
            this.deleteUserSubTab.Name = "deleteUserSubTab";
            this.deleteUserSubTab.Size = new System.Drawing.Size(951, 588);
            this.deleteUserSubTab.TabIndex = 0;
            // 
            // updateProductSubTab
            // 
            this.updateProductSubTab.BackColor = System.Drawing.Color.White;
            this.updateProductSubTab.Location = new System.Drawing.Point(0, 0);
            this.updateProductSubTab.Name = "updateProductSubTab";
            this.updateProductSubTab.Size = new System.Drawing.Size(957, 668);
            this.updateProductSubTab.TabIndex = 1;
            // 
            // removeProductSubTab
            // 
            this.removeProductSubTab.BackColor = System.Drawing.Color.White;
            this.removeProductSubTab.Location = new System.Drawing.Point(0, 0);
            this.removeProductSubTab.Name = "removeProductSubTab";
            this.removeProductSubTab.Size = new System.Drawing.Size(957, 668);
            this.removeProductSubTab.TabIndex = 2;
            // 
            // manageCategorySubTab
            // 
            this.manageCategorySubTab.BackColor = System.Drawing.Color.White;
            this.manageCategorySubTab.Location = new System.Drawing.Point(0, 0);
            this.manageCategorySubTab.Name = "manageCategorySubTab";
            this.manageCategorySubTab.Size = new System.Drawing.Size(957, 668);
            this.manageCategorySubTab.TabIndex = 3;
            // 
            // addProductSubTab
            // 
            this.addProductSubTab.BackColor = System.Drawing.Color.White;
            this.addProductSubTab.Location = new System.Drawing.Point(0, 0);
            this.addProductSubTab.Margin = new System.Windows.Forms.Padding(0);
            this.addProductSubTab.Name = "addProductSubTab";
            this.addProductSubTab.Size = new System.Drawing.Size(951, 668);
            this.addProductSubTab.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
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
            this.shopName.BackColor = System.Drawing.Color.White;
            this.shopName.Font = new System.Drawing.Font("Brush Script MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.shopName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.shopName.Location = new System.Drawing.Point(-1, -1);
            this.shopName.MaximumSize = new System.Drawing.Size(244, 0);
            this.shopName.MinimumSize = new System.Drawing.Size(244, 0);
            this.shopName.Name = "shopName";
            this.shopName.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.shopName.Size = new System.Drawing.Size(244, 83);
            this.shopName.TabIndex = 2;
            this.shopName.Text = "WonderMart";
            this.shopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sideTabs.BackColor = System.Drawing.Color.MidnightBlue;
            this.sideTabs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sideTabs.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sideTabs.FullRowSelect = true;
            this.sideTabs.ItemHeight = 30;
            this.sideTabs.Location = new System.Drawing.Point(25, 104);
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
            treeNode10.Name = "viewProducts";
            treeNode10.NodeFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "View Products";
            treeNode11.ForeColor = System.Drawing.Color.White;
            treeNode11.Name = "manageProducts";
            treeNode11.NodeFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode11.Text = "Manage Products";
            this.sideTabs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode11});
            this.sideTabs.Scrollable = false;
            this.sideTabs.ShowLines = false;
            this.sideTabs.ShowPlusMinus = false;
            this.sideTabs.Size = new System.Drawing.Size(216, 512);
            this.sideTabs.TabIndex = 1;
            this.sideTabs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SideTabs_AfterSelect);
            // 
            // userBar
            // 
            this.userBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.userBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userBar.Controls.Add(this.button1);
            this.userBar.Controls.Add(this.pictureBox1);
            this.userBar.Controls.Add(this.username);
            this.userBar.Location = new System.Drawing.Point(242, 0);
            this.userBar.Name = "userBar";
            this.userBar.Size = new System.Drawing.Size(974, 90);
            this.userBar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(835, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopManagementApplication.Properties.Resources.Group_103;
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username.Location = new System.Drawing.Point(87, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(49, 15);
            this.username.TabIndex = 2;
            this.username.Text = "Wonder";
            // 
            // manageUsersTab
            // 
            this.manageUsersTab.AutoScroll = true;
            this.manageUsersTab.Controls.Add(this.addUserSubTab);
            this.manageUsersTab.Controls.Add(this.updateUserSubTab);
            this.manageUsersTab.Controls.Add(this.deleteUserSubTab);
            this.manageUsersTab.Location = new System.Drawing.Point(242, 89);
            this.manageUsersTab.Name = "manageUsersTab";
            this.manageUsersTab.Size = new System.Drawing.Size(974, 540);
            this.manageUsersTab.TabIndex = 1;
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
            // updateProduct
            // 
            this.updateProduct.AutoSize = true;
            this.updateProduct.Location = new System.Drawing.Point(283, 25);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(90, 15);
            this.updateProduct.TabIndex = 0;
            this.updateProduct.Text = "Update Product";
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
            // manageProductsPage
            // 
            this.manageProductsPage.AutoScroll = true;
            this.manageProductsPage.BackColor = System.Drawing.Color.IndianRed;
            this.manageProductsPage.Controls.Add(this.manageCategorySubTab);
            this.manageProductsPage.Controls.Add(this.updateProductSubTab);
            this.manageProductsPage.Controls.Add(this.addProductSubTab);
            this.manageProductsPage.Controls.Add(this.removeProductSubTab);
            this.manageProductsPage.Location = new System.Drawing.Point(244, 89);
            this.manageProductsPage.Name = "manageProductsPage";
            this.manageProductsPage.Size = new System.Drawing.Size(974, 540);
            this.manageProductsPage.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(1215, 629);
            this.Controls.Add(this.userBar);
            this.Controls.Add(this.manageUsersTab);
            this.Controls.Add(this.manageProductsPage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userBar.ResumeLayout(false);
            this.userBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.manageUsersTab.ResumeLayout(false);
            this.manageProductsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SideTabs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if( e.Node.Name == "addUser" || e.Node.Name == "userMangager")
            {
                //manageProductsPage.Visible = false;
                manageUsersTab.BringToFront();
                addUserSubTab.BringToFront();
            }
            else if(e.Node.Name == "updateUser")
            {
                //manageProductsPage.BringToFront()e;
                manageUsersTab.BringToFront();
                updateUserSubTab.BringToFront();
            }
            else if(e.Node.Name == "deleteUser")
            {
                //manageProductsPage.BringToFront()e;
                manageUsersTab.BringToFront();
                deleteUserSubTab.BringToFront();
            }
            else if (e.Node.Name == "viewUsers")
            {
                //manageProductsPage.BringToFront()e;
                manageUsersTab.BringToFront();
                viewUsersSubTab.BringToFront(); 
                TableLayoutPanel utable = viewUsersSubTab.GetTable();
                utable.Visible = false;
                utable.Controls.Clear();
                utable.Controls.Add(viewUsersSubTab.lastnameHeader, 0, 0);
                utable.Controls.Add(viewUsersSubTab.label5, 5, 0);
                utable.Controls.Add(viewUsersSubTab.firstnameHeader, 1, 0);
                utable.Controls.Add(viewUsersSubTab.roleHeader, 6, 0);
                utable.Controls.Add(viewUsersSubTab.usernameHead, 2, 0);
                utable.Controls.Add(viewUsersSubTab.emailHeader, 3, 0);
                utable.Controls.Add(viewUsersSubTab.gender, 4, 0);
                utable.Controls.Add(viewUsersSubTab.phoneHeader, 7, 0);
                utable.Controls.Add(viewUsersSubTab.created_On, 8, 0);
                User.ViewUsers(utable);
                utable.Visible = true;
            }
            else if ( e.Node.Name == "addProduct" || e.Node.Name == "manageProducts")
            {
                manageUsersTab.SendToBack();
                manageProductsPage.BringToFront();
                addProductSubTab.BringToFront();
                ComboBox productCategoryComboBox = addProductSubTab.GetCategoryComboBox();
                productCategoryComboBox.Items.Clear();
                addProductSubTab.GetCategories();
            }
            else if (e.Node.Name == "updateProduct")
            {
                //manageUsersTab.BringToFront()e;
                manageProductsPage.BringToFront();
                updateProductSubTab.BringToFront();
            }
            else if (e.Node.Name == "deleteProduct")
            {
                //manageUsersTab.BringToFront()e;
                manageProductsPage.BringToFront();
                removeProductSubTab.BringToFront();
            }
            else if (e.Node.Name == "manageCategories")
            {
                manageProductsPage.BringToFront();
                manageCategorySubTab.BringToFront();
                TableLayoutPanel ctable = manageCategorySubTab.GetTable();
                ctable.Visible = false;
                ctable.Controls.Clear();
                ctable.Controls.Add(manageCategorySubTab.itemsHead, 1, 0);
                ctable.Controls.Add(manageCategorySubTab.categoryHead, 0, 0);
                ProductCategory.ViewCategory(ctable);
                ctable.Visible = true;
            }
            else if (e.Node.Name == "viewProducts")
            {
                manageProductsPage.BringToFront();
                viewProductsSubTab.BringToFront();
                TableLayoutPanel table = viewProductsSubTab.getTable();
                table.Visible = false;
                table.Controls.Clear();
                table.Controls.Add(viewProductsSubTab.label5, 4, 0);
                table.Controls.Add(viewProductsSubTab.label1, 0, 0);
                table.Controls.Add(viewProductsSubTab.label2, 1, 0);
                table.Controls.Add(viewProductsSubTab.label4, 3, 0);
                table.Controls.Add(viewProductsSubTab.label3, 2, 0);
                Product.ViewProducts(table);
                table.Visible = true;
            }
        }

        override
        protected void OnClosed(EventArgs e)
        {
            LoginScreen login = (LoginScreen)Tag;
            login.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginScreen login = (LoginScreen)Tag;
            this.Hide();
            login.Show();
        }
    }
}
