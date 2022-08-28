using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ShopManagementApplication.database;

namespace ShopManagementApplication.classes
{
    internal class Transaction
    {
        public Transaction(int pid, DateTime dot, int quantity, float netPrice)
        {
            this.pid = pid;
            this.dot = dot; 
            this.quantity = quantity;
            this.netPrice = netPrice;
        }

        private int tid;

        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }

        private int pid;

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }       

        private DateTime dot;

        public DateTime Dot
        {
            get { return dot; }
            set { dot = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private float netPrice;

        public float NetPrice
        {
            get { return netPrice; }
            set { netPrice = value; }
        }

        public static void GetDailyReport(TableLayoutPanel reportTable)
        {
            DatabaseConnection connection = new();
            string reportQuery = $"select products.productName, products.productCategory, products.productPrice, COUNT(sales.quantity) as Quantity, " +
                $"SUM(productPrice) as 'Sub Total' from products  INNER JOIN sales ON products.pid = sales.pid WHERE CAST(sales.dos AS DATE) = CURDATE() " +
                $"group by (products.productName)";

            try
            {
                MySqlCommand cmd = new(reportQuery, connection.conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new();
                dataTable.Load(reader);
                reportTable.RowCount = 1;
                reportTable.RowStyles[reportTable.RowCount - 1].Height = 40;
                foreach (DataRow row in dataTable.Rows)
                {
                    reportTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                    reportTable.RowCount += 1;
                    Label label0 = new()
                    {
                        Text = row["productName"].ToString()!,
                    };

                    Label label1 = new()
                    {
                        Text = row["productCategory"].ToString()!,
                    };

                    Label label2 = new()
                    {
                        Text = row["productPrice"].ToString()!,
                    };

                    Label label3 = new()
                    {
                        Text = row["Quantity"].ToString()!,
                    };

                    Label label4 = new()
                    {
                        Text = row["Sub Total"].ToString()!,
                    };



                    reportTable.Controls.Add(label0, 0, reportTable.RowCount - 1);
                    reportTable.Controls.Add(label1, 1, reportTable.RowCount - 1);
                    reportTable.Controls.Add(label2, 2, reportTable.RowCount - 1);
                    reportTable.Controls.Add(label3, 3, reportTable.RowCount - 1);
                    reportTable.Controls.Add(label4, 4, reportTable.RowCount - 1);
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            connection.conn.Close();
        }

    }
}
