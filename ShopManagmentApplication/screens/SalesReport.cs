using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.classes;

namespace ShopManagementApplication.screens
{
    internal class SalesReport : Form
    {
        private TableLayoutPanel reportTable;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label6;
        private Label salesNumber;
        private Label totalAmount;
        private Label label9;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label reportDate;
        private int total = 0;

        public SalesReport()
        {
            InitializeComponent();
            Transaction.GetDailyReport(reportTable);
            int rowNum = reportTable.RowCount;
            for(int i = 1; i<rowNum; i++)
            {
                total += int.Parse(reportTable.Controls[(i*5)+4].Text);
            }
            this.salesNumber.Text = (rowNum - 1).ToString();
            this.totalAmount.Text = (total).ToString();
            this.reportDate.Text = DateTime.Now.ToString();
        }

        private void InitializeComponent()
        {
            this.reportTable = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salesNumber = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.Label();
            this.reportTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTable
            // 
            this.reportTable.AutoSize = true;
            this.reportTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.reportTable.ColumnCount = 5;
            this.reportTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.reportTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.reportTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.reportTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.reportTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.reportTable.Controls.Add(this.label5, 4, 0);
            this.reportTable.Controls.Add(this.label1, 0, 0);
            this.reportTable.Controls.Add(this.label4, 3, 0);
            this.reportTable.Controls.Add(this.label2, 1, 0);
            this.reportTable.Controls.Add(this.label3, 2, 0);
            this.reportTable.Location = new System.Drawing.Point(64, 83);
            this.reportTable.Name = "reportTable";
            this.reportTable.RowCount = 2;
            this.reportTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reportTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reportTable.Size = new System.Drawing.Size(699, 46);
            this.reportTable.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sub Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Category";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Price";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(632, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sales";
            // 
            // salesNumber
            // 
            this.salesNumber.AutoSize = true;
            this.salesNumber.Location = new System.Drawing.Point(725, 34);
            this.salesNumber.Name = "salesNumber";
            this.salesNumber.Size = new System.Drawing.Size(22, 15);
            this.salesNumber.TabIndex = 1;
            this.salesNumber.Text = ".....";
            this.salesNumber.Click += new System.EventHandler(this.label7_Click);
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Location = new System.Drawing.Point(725, 60);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(22, 15);
            this.totalAmount.TabIndex = 1;
            this.totalAmount.Text = ".....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(632, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(64, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Daily Sales Report";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date:";
            // 
            // reportDate
            // 
            this.reportDate.AutoSize = true;
            this.reportDate.Location = new System.Drawing.Point(120, 60);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(19, 15);
            this.reportDate.TabIndex = 3;
            this.reportDate.Text = "....";
            // 
            // SalesReport
            // 
            this.ClientSize = new System.Drawing.Size(829, 461);
            this.Controls.Add(this.reportDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.salesNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reportTable);
            this.Name = "SalesReport";
            this.reportTable.ResumeLayout(false);
            this.reportTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
