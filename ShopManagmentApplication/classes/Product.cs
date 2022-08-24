using static System.Console;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.database;
using MySql.Data.MySqlClient;
using System.Data;

namespace ShopManagementApplication.classes
{
    internal class Product
    {
        DatabaseConnection connection;
        public Product(string productName, int inStock, float productPrice, string productCategory, string barcode, int reorderLevel, string expiryDate)
        {
            this.productName = productName;
            this.inStock = inStock;
            this.productPrice = productPrice;
            this.productCategory = productCategory;
            this.barcode = barcode;
            this.reorderLevel = reorderLevel;
            this.expiryDate = DateOnly.Parse(expiryDate, new CultureInfo("fr-FR"));
            this.available = true;
        }

        private int pid;

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private int inStock;

        public int InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }

        private float productPrice;

        public float ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        private string productCategory;

        public string ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }

        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private int reorderLevel;

        public int ReorderLevel
        {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }

        private DateOnly expiryDate;

        public DateOnly ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        private bool available;

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public void AddProduct()
        {
            connection = new();
            String insertQuery = $"INSERT INTO products(productName, productCategory, productPrice, reorderLevel, expiryDate, barcode, available)" +
                                $" VALUES('{ProductName}','{productCategory}',{ProductPrice},{ReorderLevel},STR_TO_DATE('{ExpiryDate}','%m/%d/%Y'),'{Barcode}', {1})";
            try
            {
                MySqlCommand cmd = new(insertQuery, connection.conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        public void UpdateProduct()
        {
            connection = new();
            string updateQuery = $"UPDATE products SET productName ='{ProductName}', productCategory='{ProductCategory}', " +
                $"expiryDate=STR_TO_DATE('{ExpiryDate}','%m/%d/%Y'), reorderLevel='{ReorderLevel}' WHERE barcode='{Barcode}'";

            try
            {
                MySqlCommand cmd = new(updateQuery, connection.conn);

                cmd.ExecuteNonQuery();
                ReadKey();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                ReadKey();
            }
        }

        public static void RemoveProduct(string barcode)
        {
            DatabaseConnection connection = new();
            string removeQuery = $"DELETE FROM prodcuts WHERE barcode = '{barcode}'";
            try
            {
                MySqlCommand cmd = new(removeQuery, connection.conn);

                cmd.ExecuteNonQuery();
                ReadKey();
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                ReadKey();
            }

        }

        public static void ViewProducts(TableLayoutPanel productsTable)
        {
            DatabaseConnection connection = new();
            string selectQuery = $"SELECT * FROM products";
            try
            {
                MySqlCommand cmd = new(selectQuery, connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new();
                dataTable.Load(reader);
                productsTable.RowCount = 1;
                productsTable.RowStyles[productsTable.RowCount - 1].Height = 40;
                foreach (DataRow row in dataTable.Rows)
                {
                    productsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                    productsTable.RowCount += 1;
                    Label label0 = new()
                    {
                        Text = row["name"].ToString()!,
                    };

                    Label label1 = new()
                    {
                        Text = row["email"].ToString()!,
                    };

                    Label label2 = new()
                    {
                        Text = row["gender"].ToString()!,
                    };

                    Label label3 = new()
                    {

                        Text = row["role"].ToString()!,
                    };

                    Label label4 = new()
                    {
                        Text = row["phone"].ToString()!,
                    };

                    Label label5 = new()
                    {
                        Text = row["dob"].ToString()!,
                    };

                    Label label6 = new()
                    {
                        Text = row["pincode"].ToString()!,
                    };


                    productsTable.Controls.Add(label0, 0, productsTable.RowCount - 1);
                    productsTable.Controls.Add(label5, 5, productsTable.RowCount - 1);
                    productsTable.Controls.Add(label1, 1, productsTable.RowCount - 1);
                    productsTable.Controls.Add(label6, 6, productsTable.RowCount - 1);
                    productsTable.Controls.Add(label2, 2, productsTable.RowCount - 1);
                    productsTable.Controls.Add(label4, 4, productsTable.RowCount - 1);
                    productsTable.Controls.Add(label3, 3, productsTable.RowCount - 1);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                ReadKey();
            }
        }

        public static Product? GetProduct(string barcode)
        {
            DatabaseConnection connection = new();
            string selectQuery = $"SELECT * FROM products WHERE barcode = '{barcode}'";
            try
            {
                MySqlCommand cmd = new(selectQuery, connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DateTime date = DateTime.ParseExact(reader["expiryDate"].ToString()!, "M/d/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    string dateString = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    return new Product(reader["productName"].ToString()!, 1, float.Parse(reader["productPrice"].ToString()!),
                        reader["productCategory"].ToString()!, reader["barcode"].ToString()!, int.Parse(reader["reorderLevel"].ToString()!),
                        dateString);

                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            return null;
        }

    }
}
