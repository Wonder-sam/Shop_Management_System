using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using MySql.Data.MySqlClient;
using ShopManagementApplication.classes;
using ShopManagementApplication.database;

namespace ShopManagementApplication.screens.admin.manageProducts
{
    internal class AddProduct : UserControl
    {
        private string code;
        private Label addProductHeader;
        private GroupBox productDetailsGroup;
        private TextBox productNameTextField;
        private PictureBox barcodeImage;
        private Label barcodeLabel;
        private Label expiryDateLabel;
        private Label reorderLevelLabel;
        private Label productPriceLabel;
        private Label productCategoryLabel;
        private TextBox reorderLevelTextField;
        private TextBox productPriceTextField;
        private ComboBox productCategoryComboBox;
        private DateTimePicker expiryDatePicker;
        private Button generateBtn;
        private Button addBtn;
        private Label productNameLabel;
        private Image barcode_Image;

        public AddProduct()
        {
            InitializeComponent();
            //GetCategories();
        }

        public ComboBox GetCategoryComboBox()
        {
            return productCategoryComboBox;
        }

        private void InitializeComponent()
        {
            this.addProductHeader = new System.Windows.Forms.Label();
            this.productDetailsGroup = new System.Windows.Forms.GroupBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reorderLevelTextField = new System.Windows.Forms.TextBox();
            this.productPriceTextField = new System.Windows.Forms.TextBox();
            this.productNameTextField = new System.Windows.Forms.TextBox();
            this.barcodeImage = new System.Windows.Forms.PictureBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.productDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductHeader
            // 
            this.addProductHeader.AutoSize = true;
            this.addProductHeader.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductHeader.ForeColor = System.Drawing.Color.SteelBlue;
            this.addProductHeader.Location = new System.Drawing.Point(79, 36);
            this.addProductHeader.Name = "addProductHeader";
            this.addProductHeader.Size = new System.Drawing.Size(120, 22);
            this.addProductHeader.TabIndex = 0;
            this.addProductHeader.Text = "Add Product";
            // 
            // productDetailsGroup
            // 
            this.productDetailsGroup.Controls.Add(this.generateBtn);
            this.productDetailsGroup.Controls.Add(this.productCategoryComboBox);
            this.productDetailsGroup.Controls.Add(this.expiryDatePicker);
            this.productDetailsGroup.Controls.Add(this.reorderLevelTextField);
            this.productDetailsGroup.Controls.Add(this.productPriceTextField);
            this.productDetailsGroup.Controls.Add(this.productNameTextField);
            this.productDetailsGroup.Controls.Add(this.barcodeImage);
            this.productDetailsGroup.Controls.Add(this.barcodeLabel);
            this.productDetailsGroup.Controls.Add(this.expiryDateLabel);
            this.productDetailsGroup.Controls.Add(this.reorderLevelLabel);
            this.productDetailsGroup.Controls.Add(this.productPriceLabel);
            this.productDetailsGroup.Controls.Add(this.productCategoryLabel);
            this.productDetailsGroup.Controls.Add(this.productNameLabel);
            this.productDetailsGroup.Location = new System.Drawing.Point(81, 84);
            this.productDetailsGroup.Name = "productDetailsGroup";
            this.productDetailsGroup.Size = new System.Drawing.Size(574, 472);
            this.productDetailsGroup.TabIndex = 1;
            this.productDetailsGroup.TabStop = false;
            this.productDetailsGroup.Text = "Product Details";
            this.productDetailsGroup.Enter += new System.EventHandler(this.productDetailsGroup_Enter);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(184, 417);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(155, 36);
            this.generateBtn.TabIndex = 6;
            this.generateBtn.Text = "Generate Barcode";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
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
            this.expiryDatePicker.Location = new System.Drawing.Point(28, 243);
            this.expiryDatePicker.MaximumSize = new System.Drawing.Size(197, 32);
            this.expiryDatePicker.MinimumSize = new System.Drawing.Size(197, 32);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(197, 32);
            this.expiryDatePicker.TabIndex = 4;
            // 
            // reorderLevelTextField
            // 
            this.reorderLevelTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reorderLevelTextField.Location = new System.Drawing.Point(295, 156);
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
            // barcodeImage
            // 
            this.barcodeImage.BackColor = System.Drawing.Color.Transparent;
            this.barcodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeImage.Location = new System.Drawing.Point(131, 323);
            this.barcodeImage.Name = "barcodeImage";
            this.barcodeImage.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.barcodeImage.Size = new System.Drawing.Size(263, 88);
            this.barcodeImage.TabIndex = 1;
            this.barcodeImage.TabStop = false;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(135, 296);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(53, 15);
            this.barcodeLabel.TabIndex = 0;
            this.barcodeLabel.Text = "Barcode:";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expiryDateLabel.Location = new System.Drawing.Point(28, 218);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(69, 15);
            this.expiryDateLabel.TabIndex = 0;
            this.expiryDateLabel.Text = "Expiry Date:";
            // 
            // reorderLevelLabel
            // 
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reorderLevelLabel.Location = new System.Drawing.Point(291, 131);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(81, 15);
            this.reorderLevelLabel.TabIndex = 0;
            this.reorderLevelLabel.Text = "Reorder Level:";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceLabel.Location = new System.Drawing.Point(24, 132);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(81, 15);
            this.productPriceLabel.TabIndex = 0;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCategoryLabel.Location = new System.Drawing.Point(295, 45);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(103, 15);
            this.productCategoryLabel.TabIndex = 0;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(24, 45);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(87, 15);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product Name:";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(258, 582);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(170, 45);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddProduct
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productDetailsGroup);
            this.Controls.Add(this.addProductHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(951, 668);
            this.productDetailsGroup.ResumeLayout(false);
            this.productDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            code = "productcode";
            Barcode generatedBarcode = new Barcode()
            {
                BarWidth = 1
            };
            int imageWidth = 312;
            int imageHeight = 71;
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            for(int i = 0; i < 12; i++)
            {
                int num = random.Next(10);
                code += num;
            }
            Product foundProduct = Product.GetProduct(code);
            if(foundProduct == null)
            {
                //MessageBox.Show(code);
                barcode_Image = generatedBarcode.Encode(TYPE.CODE128, code, foreColor, backColor, imageWidth, imageHeight);

                barcode_Image.Save(@"" + code + ".png", ImageFormat.Png);
                this.barcodeImage.Image = Image.FromFile(code + ".png");
            }




            //string[] barcode = BarcodeReader.Read(@"barcode.png");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string productName = productNameTextField.Text;
            string productCategory = productCategoryComboBox.Text;
            string productPrice = productPriceTextField.Text;
            string reorderLevel = reorderLevelTextField.Text;
            string expiryDate = expiryDatePicker.Text;
            string barcode = code;

            if (!string.IsNullOrEmpty(code))
            {
                Product newProduct = new Product(productName, 1, float.Parse(productPrice), productCategory,
                barcode, int.Parse(reorderLevel), expiryDate);

                newProduct.AddProduct();
            }
            else
                code = "";

        }

        private void productCategoryComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index > -1)
                e.Graphics.DrawString(productCategoryComboBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        public void GetCategories()
        {
            DatabaseConnection connection = new();
            string enumQuery = $"SELECT COLUMN_TYPE as AllPossibleEnumValues FROM INFORMATION_SCHEMA.COLUMNS " +
                $"WHERE TABLE_SCHEMA = 'shoprite' AND TABLE_NAME = 'productCategories' AND COLUMN_NAME = 'productCategory'";

            try
            {
                MySqlCommand cmd = new(enumQuery, connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string enums = reader["AllPossibleEnumValues"].ToString();
                    enums = enums.Replace("'", "");
                    enums = enums.Substring(5);
                    enums = enums.Remove(enums.Length - 1);
                    String[] enumValues = enums.Split(",");
                    this.productCategoryComboBox.Items.AddRange(enumValues);
                    this.productCategoryComboBox.SelectedIndex = 0;
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        private void productDetailsGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
