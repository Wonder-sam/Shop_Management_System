using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens.admin.manageProducts
{
    internal class DeleteProduct : UserControl
    {
        private GroupBox findUserGroup;
        private TextBox barcodeTextField;
        private Label usernameLabel;
        private Button deleteBtn;
        private GroupBox productDetailsGroup;
        private Label expiryDateLabel;
        private Label reorderLevelLabel;
        private Label inStockLabel;
        private Label productPriceLabel;
        private Label productCategoryLabel;
        private Label productNameLabel;
        private Label expiryDateText;
        private Label reorderLevelText;
        private Label inStockText;
        private Label productPriceText;
        private Label productCategoryText;
        private Label productNameText;
        private Label removeProductHeader;

        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.findUserGroup = new System.Windows.Forms.GroupBox();
            this.barcodeTextField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.productDetailsGroup = new System.Windows.Forms.GroupBox();
            this.expiryDateText = new System.Windows.Forms.Label();
            this.reorderLevelText = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.inStockText = new System.Windows.Forms.Label();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.Label();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.productCategoryText = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.removeProductHeader = new System.Windows.Forms.Label();
            this.findUserGroup.SuspendLayout();
            this.productDetailsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // findUserGroup
            // 
            this.findUserGroup.Controls.Add(this.barcodeTextField);
            this.findUserGroup.Controls.Add(this.usernameLabel);
            this.findUserGroup.Location = new System.Drawing.Point(81, 77);
            this.findUserGroup.Name = "findUserGroup";
            this.findUserGroup.Size = new System.Drawing.Size(574, 92);
            this.findUserGroup.TabIndex = 10;
            this.findUserGroup.TabStop = false;
            this.findUserGroup.Text = "Find Product";
            // 
            // barcodeTextField
            // 
            this.barcodeTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeTextField.Location = new System.Drawing.Point(20, 49);
            this.barcodeTextField.MinimumSize = new System.Drawing.Size(203, 32);
            this.barcodeTextField.Name = "barcodeTextField";
            this.barcodeTextField.Size = new System.Drawing.Size(203, 32);
            this.barcodeTextField.TabIndex = 2;
            this.barcodeTextField.TextChanged += new System.EventHandler(this.barcodeTextField_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(20, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(53, 15);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Barcode:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(278, 498);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(170, 45);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Remove";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // productDetailsGroup
            // 
            this.productDetailsGroup.Controls.Add(this.expiryDateText);
            this.productDetailsGroup.Controls.Add(this.reorderLevelText);
            this.productDetailsGroup.Controls.Add(this.expiryDateLabel);
            this.productDetailsGroup.Controls.Add(this.inStockText);
            this.productDetailsGroup.Controls.Add(this.reorderLevelLabel);
            this.productDetailsGroup.Controls.Add(this.productPriceText);
            this.productDetailsGroup.Controls.Add(this.inStockLabel);
            this.productDetailsGroup.Controls.Add(this.productCategoryText);
            this.productDetailsGroup.Controls.Add(this.productPriceLabel);
            this.productDetailsGroup.Controls.Add(this.productNameText);
            this.productDetailsGroup.Controls.Add(this.productCategoryLabel);
            this.productDetailsGroup.Controls.Add(this.productNameLabel);
            this.productDetailsGroup.Location = new System.Drawing.Point(81, 203);
            this.productDetailsGroup.Name = "productDetailsGroup";
            this.productDetailsGroup.Size = new System.Drawing.Size(574, 258);
            this.productDetailsGroup.TabIndex = 8;
            this.productDetailsGroup.TabStop = false;
            this.productDetailsGroup.Text = "Product Details";
            // 
            // expiryDateText
            // 
            this.expiryDateText.AutoSize = true;
            this.expiryDateText.Location = new System.Drawing.Point(197, 210);
            this.expiryDateText.Name = "expiryDateText";
            this.expiryDateText.Size = new System.Drawing.Size(25, 15);
            this.expiryDateText.TabIndex = 0;
            this.expiryDateText.Text = "......";
            // 
            // reorderLevelText
            // 
            this.reorderLevelText.AutoSize = true;
            this.reorderLevelText.Location = new System.Drawing.Point(197, 176);
            this.reorderLevelText.Name = "reorderLevelText";
            this.reorderLevelText.Size = new System.Drawing.Size(25, 15);
            this.reorderLevelText.TabIndex = 0;
            this.reorderLevelText.Text = "......";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expiryDateLabel.Location = new System.Drawing.Point(24, 210);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(70, 15);
            this.expiryDateLabel.TabIndex = 0;
            this.expiryDateLabel.Text = "Expiry Date:";
            // 
            // inStockText
            // 
            this.inStockText.AutoSize = true;
            this.inStockText.Location = new System.Drawing.Point(197, 141);
            this.inStockText.Name = "inStockText";
            this.inStockText.Size = new System.Drawing.Size(25, 15);
            this.inStockText.TabIndex = 0;
            this.inStockText.Text = "......";
            // 
            // reorderLevelLabel
            // 
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reorderLevelLabel.Location = new System.Drawing.Point(24, 176);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(81, 15);
            this.reorderLevelLabel.TabIndex = 0;
            this.reorderLevelLabel.Text = "Reorder Level:";
            // 
            // productPriceText
            // 
            this.productPriceText.AutoSize = true;
            this.productPriceText.Location = new System.Drawing.Point(197, 106);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(25, 15);
            this.productPriceText.TabIndex = 0;
            this.productPriceText.Text = "......";
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inStockLabel.Location = new System.Drawing.Point(24, 141);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(101, 15);
            this.inStockLabel.TabIndex = 0;
            this.inStockLabel.Text = "Number In Stock:";
            // 
            // productCategoryText
            // 
            this.productCategoryText.AutoSize = true;
            this.productCategoryText.Location = new System.Drawing.Point(197, 71);
            this.productCategoryText.Name = "productCategoryText";
            this.productCategoryText.Size = new System.Drawing.Size(25, 15);
            this.productCategoryText.TabIndex = 0;
            this.productCategoryText.Text = "......";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productPriceLabel.Location = new System.Drawing.Point(24, 106);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(81, 15);
            this.productPriceLabel.TabIndex = 0;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // productNameText
            // 
            this.productNameText.AutoSize = true;
            this.productNameText.Location = new System.Drawing.Point(197, 38);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(25, 15);
            this.productNameText.TabIndex = 0;
            this.productNameText.Text = "......";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productCategoryLabel.Location = new System.Drawing.Point(24, 71);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(102, 15);
            this.productCategoryLabel.TabIndex = 0;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(24, 38);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(87, 15);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name:";
            // 
            // removeProductHeader
            // 
            this.removeProductHeader.AutoSize = true;
            this.removeProductHeader.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeProductHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.removeProductHeader.Location = new System.Drawing.Point(79, 31);
            this.removeProductHeader.Name = "removeProductHeader";
            this.removeProductHeader.Size = new System.Drawing.Size(150, 22);
            this.removeProductHeader.TabIndex = 7;
            this.removeProductHeader.Text = "Remove Product";
            // 
            // DeleteProduct
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.findUserGroup);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.productDetailsGroup);
            this.Controls.Add(this.removeProductHeader);
            this.Name = "DeleteProduct";
            this.Size = new System.Drawing.Size(951, 634);
            this.findUserGroup.ResumeLayout(false);
            this.findUserGroup.PerformLayout();
            this.productDetailsGroup.ResumeLayout(false);
            this.productDetailsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string barcode = barcodeTextField.Text;
            Product.RemoveProduct(barcode);
        }

        private void barcodeTextField_TextChanged(object sender, EventArgs e)
        {
            string barcode = barcodeTextField.Text;
            if(barcode.Length == 23)
            {
                Product targetProduct = Product.GetProduct(barcode)!;
                if (targetProduct == null)
                {
                    MessageBox.Show("User doesnt exist");
                }
                else
                {
                    productNameText.Text = targetProduct.ProductName;
                    productCategoryText.Text = targetProduct.ProductCategory;
                    productPriceText.Text = targetProduct.ProductPrice.ToString();
                    reorderLevelText.Text = targetProduct.ReorderLevel.ToString();
                    expiryDateText.Text = targetProduct.ExpiryDate.ToString();
                    inStockText.Text = targetProduct.ToString();
                }
            }
            
        }

    }
}
