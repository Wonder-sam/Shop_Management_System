using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ShopManagementApplication.classes;
using MySql.Data.MySqlClient;
using ShopManagementApplication.database;
using System.Drawing.Printing;

namespace ShopManagementApplication.screens.attendant
{
    internal class AttendantScreen : Form
    {
        private DatabaseConnection connection;
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
        private Label receiptLabel;
        private Label tillAmount;
        private Label noOfSales;
        private PictureBox barcodeImage;
        private TextBox textBox1;
        private Panel panel2;
        private Panel receiptPanel;
        private Button confirmBtn;
        private Button clearBtn;
        private Panel panel3;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private int numRows = 0;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private List<int> pid = new List<int> ();
        private string stringToPrint = "";
        private string documentContents;
        StreamWriter writer;

        public AttendantScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.receiptPanel = new System.Windows.Forms.Panel();
            this.salesTable = new System.Windows.Forms.TableLayoutPanel();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.noOfSalesLabel = new System.Windows.Forms.Label();
            this.tillLabel = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.Label();
            this.productCategoryText = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.tillPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.barcodeImage = new System.Windows.Forms.PictureBox();
            this.quantityField = new System.Windows.Forms.NumericUpDown();
            this.tillAmount = new System.Windows.Forms.Label();
            this.noOfSales = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.receiptPanel.SuspendLayout();
            this.tillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.receiptPanel);
            this.panel2.Controls.Add(this.confirmBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Location = new System.Drawing.Point(623, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 514);
            this.panel2.TabIndex = 1;
            // 
            // receiptPanel
            // 
            this.receiptPanel.BackColor = System.Drawing.Color.White;
            this.receiptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptPanel.Controls.Add(this.salesTable);
            this.receiptPanel.Controls.Add(this.receiptLabel);
            this.receiptPanel.Location = new System.Drawing.Point(22, 38);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(327, 388);
            this.receiptPanel.TabIndex = 15;
            // 
            // salesTable
            // 
            this.salesTable.AutoSize = true;
            this.salesTable.BackColor = System.Drawing.Color.Transparent;
            this.salesTable.ColumnCount = 3;
            this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.salesTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesTable.Location = new System.Drawing.Point(34, 49);
            this.salesTable.Name = "salesTable";
            this.salesTable.RowCount = 1;
            this.salesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.salesTable.Size = new System.Drawing.Size(245, 37);
            this.salesTable.TabIndex = 13;
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.receiptLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiptLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptLabel.Location = new System.Drawing.Point(34, 13);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(46, 15);
            this.receiptLabel.TabIndex = 12;
            this.receiptLabel.Text = "Receipt";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmBtn.Location = new System.Drawing.Point(202, 432);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(89, 30);
            this.confirmBtn.TabIndex = 14;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(57, 432);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(89, 30);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // noOfSalesLabel
            // 
            this.noOfSalesLabel.AutoSize = true;
            this.noOfSalesLabel.BackColor = System.Drawing.Color.Transparent;
            this.noOfSalesLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noOfSalesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noOfSalesLabel.Location = new System.Drawing.Point(430, 20);
            this.noOfSalesLabel.Name = "noOfSalesLabel";
            this.noOfSalesLabel.Size = new System.Drawing.Size(56, 18);
            this.noOfSalesLabel.TabIndex = 0;
            this.noOfSalesLabel.Text = "Sales:";
            // 
            // tillLabel
            // 
            this.tillLabel.AutoSize = true;
            this.tillLabel.BackColor = System.Drawing.Color.Transparent;
            this.tillLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tillLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tillLabel.Location = new System.Drawing.Point(23, 20);
            this.tillLabel.Name = "tillLabel";
            this.tillLabel.Size = new System.Drawing.Size(48, 18);
            this.tillLabel.TabIndex = 0;
            this.tillLabel.Text = "Till:";
            // 
            // productPriceText
            // 
            this.productPriceText.AutoSize = true;
            this.productPriceText.BackColor = System.Drawing.Color.Transparent;
            this.productPriceText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.productCategoryText.BackColor = System.Drawing.Color.Transparent;
            this.productCategoryText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.productPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.productPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productPriceLabel.Location = new System.Drawing.Point(144, 275);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(81, 15);
            this.productPriceLabel.TabIndex = 9;
            this.productPriceLabel.Text = "Product Price:";
            // 
            // productNameText
            // 
            this.productNameText.AutoSize = true;
            this.productNameText.BackColor = System.Drawing.Color.Transparent;
            this.productNameText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productNameText.Location = new System.Drawing.Point(278, 192);
            this.productNameText.Margin = new System.Windows.Forms.Padding(0);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(87, 15);
            this.productNameText.TabIndex = 10;
            this.productNameText.Text = "Product Name:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.productCategoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productCategoryLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productCategoryLabel.Location = new System.Drawing.Point(144, 235);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(102, 15);
            this.productCategoryLabel.TabIndex = 11;
            this.productCategoryLabel.Text = "Product Category:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productNameLabel.Location = new System.Drawing.Point(144, 192);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(87, 15);
            this.productNameLabel.TabIndex = 12;
            this.productNameLabel.Text = "Product Name:";
            // 
            // tillPanel
            // 
            this.tillPanel.BackColor = System.Drawing.Color.White;
            this.tillPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tillPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tillPanel.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(396, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(11, 23);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.quantityField.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.tillAmount.BackColor = System.Drawing.Color.Transparent;
            this.tillAmount.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tillAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tillAmount.Location = new System.Drawing.Point(77, 20);
            this.tillAmount.Name = "tillAmount";
            this.tillAmount.Size = new System.Drawing.Size(48, 18);
            this.tillAmount.TabIndex = 0;
            this.tillAmount.Text = "Till:";
            // 
            // noOfSales
            // 
            this.noOfSales.AutoSize = true;
            this.noOfSales.BackColor = System.Drawing.Color.Transparent;
            this.noOfSales.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noOfSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.noOfSales.Location = new System.Drawing.Point(492, 20);
            this.noOfSales.Name = "noOfSales";
            this.noOfSales.Size = new System.Drawing.Size(56, 18);
            this.noOfSales.TabIndex = 0;
            this.noOfSales.Text = "Sales:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantityLabel.Location = new System.Drawing.Point(144, 309);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 15);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(33, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // AttendantScreen
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 513);
            this.Controls.Add(this.tillPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendantScreen";
            this.panel2.ResumeLayout(false);
            this.receiptPanel.ResumeLayout(false);
            this.receiptPanel.PerformLayout();
            this.tillPanel.ResumeLayout(false);
            this.tillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityField)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        override
        protected void OnClosed(EventArgs e)
        {

        }

        private void quantityField_ValueChanged(object sender, EventArgs e)
        {
            int subAmount = (int)quantityField.Value * int.Parse(productPriceText.Text);
            salesTable.Controls.RemoveByKey("sub"+(numRows-1));
            salesTable.Controls.RemoveByKey("quant"+(numRows-1));
            salesTable.Controls.Add(new Label() { Text = quantityField.Value.ToString(), Name = "quant" + (numRows - 1) }, 1, numRows - 1);
            salesTable.Controls.Add(new Label() { Text = subAmount.ToString(), Name = "sub" + (numRows - 1) }, 2, numRows - 1);
            textBox1.Focus();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string barcode = textBox1.Text;
            if (barcode.Length == 23)
            {
                Product targetProduct = Product.GetProduct(barcode)!;
                if (targetProduct == null)
                {
                    MessageBox.Show("Product doesnt exist");
                }
                else
                {
                    productNameText.Text = targetProduct.ProductName;
                    productCategoryText.Text = targetProduct.ProductCategory;
                    productPriceText.Text = targetProduct.ProductPrice.ToString();
                    barcodeImage.Image = Image.FromFile("barcode.png");
                    pid.Add(targetProduct.Pid);

                    int subAmount = (int)quantityField.Value * int.Parse(productPriceText.Text);
                    salesTable.Controls.Add(new Label() { Text = productNameText.Text }, 0, numRows);
                    salesTable.Controls.Add(new Label() { Text = quantityField.Text, Name = "quant"+numRows }, 1, numRows);
                    salesTable.Controls.Add(new Label() { Text = subAmount.ToString(), Name = "sub"+numRows }, 2, numRows);
                    numRows++;
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            salesTable.Controls.Clear();
            numRows = 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            connection = new();
            int i = 1;
            String insertQuery = "";
            using (StreamWriter writer = new StreamWriter("texxt.txt"))
            {
                writer.WriteLine("-------------------SHOPRITE------------------");
                writer.WriteLine("---------------------------------------------");
                foreach (Control item in salesTable.Controls)
                {
                    writer.Write(item.Text +"\t\t");
                    if (i % 3 == 0)
                        writer.WriteLine("\n---------------------------------------------");
                    if (i % 3 == 2)
                    {
                        insertQuery += "INSERT INTO sales(pid, quantity) VALUES(" + pid.ElementAt((i / 2) - 1) + ", ";
                        insertQuery += item.Text.ToString() + ");";
                        i++;
                        continue;
                    }
                    i++;
                }
            }
           
            Console.WriteLine(insertQuery);
            try
            {
                //    MySqlCommand cmd = new(insertQuery, connection.conn);

                //    cmd.ExecuteNonQuery();
                ReadDocument();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

       
        private void ReadDocument()
        {

            string docName = "texxt.txt";
            string docPath = @"c:\Users\HP\Documents\";
            printDocument1.DocumentName = docName;
            //using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(docName))
            {
                documentContents = reader.ReadToEnd();
            }
            stringToPrint = documentContents;
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 5;
            int linesPerPage = 10;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericDefault,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericDefault);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }
    }
}
