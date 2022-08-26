
namespace ShopManagementApplication.screens.admin.manageProducts
{
    internal class ManageCategory : UserControl
    {
        private GroupBox addOrRemoveGroup;
        private Button button2;
        private Button button1;
        private TextBox categoryTextField;
        private Label categoryLabel;
        private Label removeProductHeader;
        private Panel productCategoriesPanel;

        public ManageCategory()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.addOrRemoveGroup = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryTextField = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.removeProductHeader = new System.Windows.Forms.Label();
            this.productCategoriesPanel = new System.Windows.Forms.Panel();
            this.addOrRemoveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // addOrRemoveGroup
            // 
            this.addOrRemoveGroup.Controls.Add(this.button2);
            this.addOrRemoveGroup.Controls.Add(this.button1);
            this.addOrRemoveGroup.Controls.Add(this.categoryTextField);
            this.addOrRemoveGroup.Controls.Add(this.categoryLabel);
            this.addOrRemoveGroup.Location = new System.Drawing.Point(68, 89);
            this.addOrRemoveGroup.Name = "addOrRemoveGroup";
            this.addOrRemoveGroup.Size = new System.Drawing.Size(574, 92);
            this.addOrRemoveGroup.TabIndex = 12;
            this.addOrRemoveGroup.TabStop = false;
            this.addOrRemoveGroup.Text = "Add | Remove Category";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(254, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(378, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // categoryTextField
            // 
            this.categoryTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryTextField.Location = new System.Drawing.Point(20, 49);
            this.categoryTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.categoryTextField.Name = "categoryTextField";
            this.categoryTextField.Size = new System.Drawing.Size(203, 32);
            this.categoryTextField.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.Location = new System.Drawing.Point(20, 30);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(57, 15);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category:";
            // 
            // removeProductHeader
            // 
            this.removeProductHeader.AutoSize = true;
            this.removeProductHeader.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeProductHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.removeProductHeader.Location = new System.Drawing.Point(66, 43);
            this.removeProductHeader.Name = "removeProductHeader";
            this.removeProductHeader.Size = new System.Drawing.Size(260, 22);
            this.removeProductHeader.TabIndex = 11;
            this.removeProductHeader.Text = "Manage Product Categories";
            // 
            // productCategoriesPanel
            // 
            this.productCategoriesPanel.AutoScroll = true;
            this.productCategoriesPanel.Location = new System.Drawing.Point(68, 213);
            this.productCategoriesPanel.Name = "productCategoriesPanel";
            this.productCategoriesPanel.Size = new System.Drawing.Size(574, 334);
            this.productCategoriesPanel.TabIndex = 13;
            // 
            // ManageCategory
            // 
            this.Controls.Add(this.productCategoriesPanel);
            this.Controls.Add(this.addOrRemoveGroup);
            this.Controls.Add(this.removeProductHeader);
            this.Name = "ManageCategory";
            this.Size = new System.Drawing.Size(951, 634);
            this.addOrRemoveGroup.ResumeLayout(false);
            this.addOrRemoveGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Visible = true;    

        }
    }
}
