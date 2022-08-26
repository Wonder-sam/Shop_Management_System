using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens.admin.manageProducts
{
    internal class UpdateProduct: UserControl
    {
        private Button updateBtn;
        private GroupBox productDetailsGroup;
        private ComboBox productCategoryComboBox;
        private DateTimePicker expiryDatePicker;
        private NumericUpDown inStockNumberField;
        private TextBox reorderLevelTextField;
        private TextBox productPriceTextField;
        private TextBox productNameTextField;
        private Label expiryDateLabel;
        private Label reorderLevelLabel;
        private Label inStockLabel;
        private Label productPriceLabel;
        private Label productCategoryLabel;
        private Label productNameLabel;
        private GroupBox findUserGroup;
        private Label usernameLabel;
        private TextBox barcodeTextField;
        private Label updateProductHeader;

        public UpdateProduct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.updateBtn = new System.Windows.Forms.Button();
            this.productDetailsGroup = new System.Windows.Forms.GroupBox();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.inStockNumberField = new System.Windows.Forms.NumericUpDown();
            this.reorderLevelTextField = new System.Windows.Forms.TextBox();
            this.productPriceTextField = new System.Windows.Forms.TextBox();
            this.productNameTextField = new System.Windows.Forms.TextBox();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.updateProductHeader = new System.Windows.Forms.Label();
            this.findUserGroup = new System.Windows.Forms.GroupBox();
            this.barcodeTextField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.productDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStockNumberField)).BeginInit();
            this.findUserGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(256, 567);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(170, 45);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // productDetailsGroup
            // 
            this.productDetailsGroup.Controls.Add(this.productCategoryComboBox);
            this.productDetailsGroup.Controls.Add(this.expiryDatePicker);
            this.productDetailsGroup.Controls.Add(this.inStockNumberField);
            this.productDetailsGroup.Controls.Add(this.reorderLevelTextField);
            this.productDetailsGroup.Controls.Add(this.productPriceTextField);
            this.productDetailsGroup.Controls.Add(this.productNameTextField);
            this.productDetailsGroup.Controls.Add(this.expiryDateLabel);
            this.productDetailsGroup.Controls.Add(this.reorderLevelLabel);
            this.productDetailsGroup.Controls.Add(this.inStockLabel);
            this.productDetailsGroup.Controls.Add(this.productPriceLabel);
            this.productDetailsGroup.Controls.Add(this.productCategoryLabel);
            this.productDetailsGroup.Controls.Add(this.productNameLabel);
            this.productDetailsGroup.Location = new System.Drawing.Point(81, 211);
            this.productDetailsGroup.Name = "productDetailsGroup";
            this.productDetailsGroup.Size = new System.Drawing.Size(574, 329);
            this.productDetailsGroup.TabIndex = 4;
            this.productDetailsGroup.TabStop = false;
            this.productDetailsGroup.Text = "Product Details";
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.ItemHeight = 26;
            this.productCategoryComboBox.Location = new System.Drawing.Point(295, 69);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(197, 32);
            this.productCategoryComboBox.TabIndex = 5;
            this.productCategoryComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.productCategoryComboBox_DrawItem);
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.CustomFormat = "dd/MM/yyyy";
            this.expiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDatePicker.Location = new System.Drawing.Point(295, 243);
            this.expiryDatePicker.MaximumSize = new System.Drawing.Size(197, 32);
            this.expiryDatePicker.MinimumSize = new System.Drawing.Size(197, 32);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(197, 32);
            this.expiryDatePicker.TabIndex = 4;
            // 
            // inStockNumberField
            // 
            this.inStockNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inStockNumberField.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inStockNumberField.Location = new System.Drawing.Point(295, 156);
            this.inStockNumberField.MaximumSize = new System.Drawing.Size(197, 0);
            this.inStockNumberField.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.inStockNumberField.MinimumSize = new System.Drawing.Size(197, 0);
            this.inStockNumberField.Name = "inStockNumberField";
            this.inStockNumberField.Size = new System.Drawing.Size(197, 25);
            this.inStockNumberField.TabIndex = 3;
            this.inStockNumberField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inStockNumberField.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // reorderLevelTextField
            // 
            this.reorderLevelTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reorderLevelTextField.Location = new System.Drawing.Point(28, 243);
            this.reorderLevelTextField.MaximumSize = new System.Drawing.Size(197, 32);
            this.reorderLevelTextField.MinimumSize = new System.Drawing.Size(197, 32);
            this.reorderLevelTextField.Name = "reorderLevelTextField";
            this.reorderLevelTextField.Size = new System.Drawing.Size(197, 32);
            this.reorderLevelTextField.TabIndex = 2;
            // 
            // productPriceTextField
            // 
            this.productPriceTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPriceTextField.Location = new System.Drawing.Point(28, 156);
            this.productPriceTextField.MaximumSize = new System.Drawing.Size(197, 32);
            this.productPriceTextField.MinimumSize = new System.Drawing.Size(197, 32);
            this.productPriceTextField.Name = "productPriceTextField";
            this.productPriceTextField.Size = new System.Drawing.Size(197, 32);
            this.productPriceTextField.TabIndex = 2;
            // 
            // productNameTextField
            // 
            this.productNameTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameTextField.Location = new System.Drawing.Point(28, 70);
            this.productNameTextField.MaximumSize = new System.Drawing.Size(197, 32);
            this.productNameTextField.MinimumSize = new System.Drawing.Size(197, 32);
            this.productNameTextField.Name = "productNameTextField";
            this.productNameTextField.Size = new System.Drawing.Size(197, 32);
            this.productNameTextField.TabIndex = 2;
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expiryDateLabel.Location = new System.Drawing.Point(295, 218);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(70, 15);
            this.expiryDateLabel.TabIndex = 0;
            this.expiryDateLabel.Text = "Expiry Date:";
            // 
            // reorderLevelLabel
            // 
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reorderLevelLabel.Location = new System.Drawing.Point(24, 218);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(81, 15);
            this.reorderLevelLabel.TabIndex = 0;
            this.reorderLevelLabel.Text = "Reorder Level:";
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inStockLabel.Location = new System.Drawing.Point(295, 132);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(101, 15);
            this.inStockLabel.TabIndex = 0;
            this.inStockLabel.Text = "Number In Stock:";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productPriceLabel.Location = new System.Drawing.Point(24, 132);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(81, 15);
            this.productPriceLabel.TabIndex = 0;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productCategoryLabel.Location = new System.Drawing.Point(295, 45);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(102, 15);
            this.productCategoryLabel.TabIndex = 0;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(24, 45);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(87, 15);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name:";
            // 
            // updateProductHeader
            // 
            this.updateProductHeader.AutoSize = true;
            this.updateProductHeader.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateProductHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.updateProductHeader.Location = new System.Drawing.Point(79, 39);
            this.updateProductHeader.Name = "updateProductHeader";
            this.updateProductHeader.Size = new System.Drawing.Size(210, 22);
            this.updateProductHeader.TabIndex = 3;
            this.updateProductHeader.Text = "Edit Product Details";
            // 
            // findUserGroup
            // 
            this.findUserGroup.Controls.Add(this.barcodeTextField);
            this.findUserGroup.Controls.Add(this.usernameLabel);
            this.findUserGroup.Location = new System.Drawing.Point(81, 85);
            this.findUserGroup.Name = "findUserGroup";
            this.findUserGroup.Size = new System.Drawing.Size(574, 92);
            this.findUserGroup.TabIndex = 6;
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
            this.barcodeTextField.TextChanged += new System.EventHandler(this.usernameTextField_TextChanged);
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
            // UpdateProduct
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.findUserGroup);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.productDetailsGroup);
            this.Controls.Add(this.updateProductHeader);
            this.Name = "UpdateProduct";
            this.Size = new System.Drawing.Size(951, 634);
            this.productDetailsGroup.ResumeLayout(false);
            this.productDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStockNumberField)).EndInit();
            this.findUserGroup.ResumeLayout(false);
            this.findUserGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void usernameTextField_TextChanged(object sender, EventArgs e)
        {
            string barcode = barcodeTextField.Text;
            if( barcode.Length == 23)
            {
                Product targetProduct = Product.GetProduct(barcode)!;
                if (targetProduct == null)
                {
                    MessageBox.Show("User doesnt exist");
                }
                else
                {
                    productNameTextField.Text = targetProduct.ProductName;
                    productCategoryComboBox.Text = targetProduct.ProductCategory;
                    productPriceTextField.Text = targetProduct.ProductPrice.ToString();
                    reorderLevelTextField.Text = targetProduct.ReorderLevel.ToString();
                    expiryDatePicker.Text = targetProduct.ExpiryDate.ToString();
                    inStockNumberField.Text = targetProduct.ToString();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string barcode = barcodeTextField.Text;
            if(barcode.Length == 23)
            {
                string productName = productNameTextField.Text;
                string productCategory = productCategoryComboBox.Text;
                string productPrice = productPriceTextField.Text;
                string reorderLevel = reorderLevelTextField.Text;
                string expiryDate = expiryDatePicker.Text;
                Product newProduct = new Product(productName, 1, float.Parse(productPrice), productCategory,
                   barcode, int.Parse(reorderLevel), expiryDate);
                newProduct.UpdateProduct();
            }
           
        }

        private void productCategoryComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index > -1)
                e.Graphics.DrawString(productCategoryComboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

    }
}
