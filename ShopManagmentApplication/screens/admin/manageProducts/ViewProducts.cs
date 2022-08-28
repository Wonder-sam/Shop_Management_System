using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens.admin.manageProducts
{
    internal class ViewProducts: UserControl
    {
        public Label label1;
        public Label label5;
        public Label label4;
        public Label label2;
        public Label label3;
        private Label label6;
        private TableLayoutPanel productTable;

        public ViewProducts()
        {
            InitializeComponent();
            Product.ViewProducts(productTable);
        }

        public TableLayoutPanel getTable()
        {
            return productTable;
        }

        private void InitializeComponent()
        {
            this.productTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTable
            // 
            this.productTable.AutoSize = true;
            this.productTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.productTable.ColumnCount = 5;
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.Controls.Add(this.label5, 4, 0);
            this.productTable.Controls.Add(this.label1, 0, 0);
            this.productTable.Controls.Add(this.label2, 1, 0);
            this.productTable.Controls.Add(this.label4, 3, 0);
            this.productTable.Controls.Add(this.label3, 2, 0);
            this.productTable.Location = new System.Drawing.Point(81, 108);
            this.productTable.Name = "productTable";
            this.productTable.RowCount = 2;
            this.productTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.productTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.productTable.Size = new System.Drawing.Size(702, 64);
            this.productTable.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "In Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductCategory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reorder level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(81, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Products";
            // 
            // ViewProducts
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productTable);
            this.Name = "ViewProducts";
            this.Size = new System.Drawing.Size(951, 634);
            this.productTable.ResumeLayout(false);
            this.productTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
