using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApplication.screens.attendant
{
    internal class AttendantScreen : Form
    {
        private Panel panel1;
        private Label noOfSalesLabel;
        private Label tillLabel;
        private Label productPriceText;
        private Label productCategoryText;
        private Label productPriceLabel;
        private Label productNameText;
        private Label productCategoryLabel;
        private Label productNameLabel;
        private Panel tillPanel;
        private NumericUpDown quantityField;
        private Label quantityLabel;
        private TableLayoutPanel salesTable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label tillAmount;
        private Label noOfSales;
        private PictureBox barcodeImage;
        private Panel panel2;

        public AttendantScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salesTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noOfSalesLabel = new System.Windows.Forms.Label();
            this.tillLabel = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.Label();
            this.productCategoryText = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.tillPanel = new System.Windows.Forms.Panel();
            this.barcodeImage = new System.Windows.Forms.PictureBox();
            this.quantityField = new System.Windows.Forms.NumericUpDown();
            this.tillAmount = new System.Windows.Forms.Label();
            this.noOfSales = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.salesTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(623, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // salesTable
            // 
            this.salesTable.AutoSize = true;
            this.salesTable.ColumnCount = 3;
            this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesTable.Location = new System.Drawing.Point(53, 85);
            this.salesTable.Name = "salesTable";
            this.salesTable.RowCount = 1;
            this.salesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.salesTable.Size = new System.Drawing.Size(245, 37);
            this.salesTable.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Price:";
            // 
            // noOfSalesLabel
            // 
            this.noOfSalesLabel.AutoSize = true;
            this.noOfSalesLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noOfSalesLabel.Location = new System.Drawing.Point(430, 20);
            this.noOfSalesLabel.Name = "noOfSalesLabel";
            this.noOfSalesLabel.Size = new System.Drawing.Size(56, 18);
            this.noOfSalesLabel.TabIndex = 0;
            this.noOfSalesLabel.Text = "Sales:";
            // 
            // tillLabel
            // 
            this.tillLabel.AutoSize = true;
            this.tillLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tillLabel.Location = new System.Drawing.Point(23, 20);
            this.tillLabel.Name = "tillLabel";
            this.tillLabel.Size = new System.Drawing.Size(48, 18);
            this.tillLabel.TabIndex = 0;
            this.tillLabel.Text = "Till:";
            // 
            // productPriceText
            // 
            this.productPriceText.AutoSize = true;
            this.productPriceText.Location = new System.Drawing.Point(278, 275);
            this.productPriceText.Margin = new System.Windows.Forms.Padding(0);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(81, 15);
            this.productPriceText.TabIndex = 6;
            this.productPriceText.Text = "Product Price:";
            // 
            // productCategoryText
            // 
            this.productCategoryText.AutoSize = true;
            this.productCategoryText.Location = new System.Drawing.Point(278, 235);
            this.productCategoryText.Margin = new System.Windows.Forms.Padding(0);
            this.productCategoryText.Name = "productCategoryText";
            this.productCategoryText.Size = new System.Drawing.Size(103, 15);
            this.productCategoryText.TabIndex = 8;
            this.productCategoryText.Text = "Product Category:";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productPriceLabel.Location = new System.Drawing.Point(144, 275);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(81, 15);
            this.productPriceLabel.TabIndex = 9;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // productNameText
            // 
            this.productNameText.AutoSize = true;
            this.productNameText.Location = new System.Drawing.Point(278, 192);
            this.productNameText.Margin = new System.Windows.Forms.Padding(0);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(87, 15);
            this.productNameText.TabIndex = 10;
            this.productNameText.Text = "Product Name:";
            this.productNameText.Click += new System.EventHandler(this.productNameText_Click);
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productCategoryLabel.Location = new System.Drawing.Point(144, 235);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(102, 15);
            this.productCategoryLabel.TabIndex = 11;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(144, 192);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(87, 15);
            this.productNameLabel.TabIndex = 12;
            this.productNameLabel.Text = "Product Name:";
            // 
            // tillPanel
            // 
            this.tillPanel.Controls.Add(this.barcodeImage);
            this.tillPanel.Controls.Add(this.quantityField);
            this.tillPanel.Controls.Add(this.productPriceText);
            this.tillPanel.Controls.Add(this.tillAmount);
            this.tillPanel.Controls.Add(this.tillLabel);
            this.tillPanel.Controls.Add(this.productCategoryText);
            this.tillPanel.Controls.Add(this.noOfSales);
            this.tillPanel.Controls.Add(this.noOfSalesLabel);
            this.tillPanel.Controls.Add(this.quantityLabel);
            this.tillPanel.Controls.Add(this.productPriceLabel);
            this.tillPanel.Controls.Add(this.productNameLabel);
            this.tillPanel.Controls.Add(this.productNameText);
            this.tillPanel.Controls.Add(this.productCategoryLabel);
            this.tillPanel.Location = new System.Drawing.Point(12, 86);
            this.tillPanel.Name = "tillPanel";
            this.tillPanel.Size = new System.Drawing.Size(594, 415);
            this.tillPanel.TabIndex = 2;
            // 
            // barcodeImage
            // 
            this.barcodeImage.BackColor = System.Drawing.Color.Transparent;
            this.barcodeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeImage.Location = new System.Drawing.Point(127, 82);
            this.barcodeImage.Name = "barcodeImage";
            this.barcodeImage.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.barcodeImage.Size = new System.Drawing.Size(263, 88);
            this.barcodeImage.TabIndex = 14;
            this.barcodeImage.TabStop = false;
            // 
            // quantityField
            // 
            this.quantityField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityField.Location = new System.Drawing.Point(278, 301);
            this.quantityField.Name = "quantityField";
            this.quantityField.Size = new System.Drawing.Size(86, 23);
            this.quantityField.TabIndex = 13;
            this.quantityField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityField.ValueChanged += new System.EventHandler(this.quantityField_ValueChanged);
            // 
            // tillAmount
            // 
            this.tillAmount.AutoSize = true;
            this.tillAmount.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tillAmount.Location = new System.Drawing.Point(77, 20);
            this.tillAmount.Name = "tillAmount";
            this.tillAmount.Size = new System.Drawing.Size(48, 18);
            this.tillAmount.TabIndex = 0;
            this.tillAmount.Text = "Till:";
            // 
            // noOfSales
            // 
            this.noOfSales.AutoSize = true;
            this.noOfSales.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noOfSales.Location = new System.Drawing.Point(492, 20);
            this.noOfSales.Name = "noOfSales";
            this.noOfSales.Size = new System.Drawing.Size(56, 18);
            this.noOfSales.TabIndex = 0;
            this.noOfSales.Text = "Sales:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(144, 309);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 15);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // AttendantScreen
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 513);
            this.Controls.Add(this.tillPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendantScreen";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tillPanel.ResumeLayout(false);
            this.tillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).EndInit();
            this.ResumeLayout(false);

        }

        override
        protected void OnClosed(EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productNameText_Click(object sender, EventArgs e)
        {
            int subAmount = (int)quantityField.Value * int.Parse(productPriceText.Text);
            salesTable.Controls.Add(new Label() { Text = productNameText.Text }, 0, 0);
            salesTable.Controls.Add(new Label() { Text =quantityField.Text }, 1, 0);
            salesTable.Controls.Add(new Label() { Text = subAmount.ToString(), Name = "sub" }, 2, 0);
        }

        private void quantityField_ValueChanged(object sender, EventArgs e)
        {
            int subAmount = (int)quantityField.Value * int.Parse(productPriceText.Text);
            foreach (Control item in salesTable.Controls)
            {
                if (item.Name == "bloodyControl")
                {
                    salesTable.Controls.Remove(item);
                    break;
                }
            }
            salesTable.Controls.Add(new Label() { Text = subAmount.ToString() }, 2, 0);
        }
    }
}
