using System.Data;
using MySql.Data.MySqlClient;
using ShopManagementApplication.database;

namespace ShopManagementApplication.classes
{
    internal class ProductCategory
    {
        private DatabaseConnection connection;
        public ProductCategory(string category)
        {
            this.category = category;
        }
        
        private int cid;

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private int numberOfItems;

        public int NumberOfItems
        {
            get { return numberOfItems; }
            set { numberOfItems = value; }
        }

        public void AddCategory()
        {
            connection = new();
            string[] enumValues = GetCategories();
            string alterQuery = $"ALTER TABLE productCategories MODIFY productCategory enum(";
            foreach(string value in enumValues)
            {
                alterQuery += $"'{value}',";
            }
            alterQuery += $"'{Category}')";
            try
            {
                MySqlCommand cmd = new(alterQuery, connection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product category added succesfully");
                connection.conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public void RemoveCategory()
        {
            connection = new();
            string[] enumValues = GetCategories();
            for(int i = 0; i < enumValues.Length; i++)
            {
                if (enumValues[i] == Category)
                {
                    enumValues[i] = null;
                    break;
                }
            }
            string alterQuery = $"ALTER TABLE productCategories MODIFY productCategory enum(";
            foreach (string value in enumValues)
            {
                if(value != null)
                    alterQuery += $"'{value}',";
            }
            alterQuery =alterQuery.Substring(0, alterQuery.Length - 1);
            alterQuery += ")";
            try
            {
                MySqlCommand cmd = new(alterQuery, connection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product removed added succesfully");
                connection.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public string[] GetCategories()
        {
            connection = new();
            string[] enumValues = null;
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
                    enumValues = enums.Split(",");
                }
                reader.Close();
                return enumValues;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.conn.Close();
            return null;
        }

        public static void ViewCategory(TableLayoutPanel categoryTable)
        {
            DatabaseConnection connection = new();
            string selectQuery = $"SELECT productCategory, COUNT(productCategory) as inStock FROM products" +
                $"  WHERE available =1 group by productCategory";
            try
            {
                MySqlCommand cmd = new(selectQuery, connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new();
                dataTable.Load(reader);
                categoryTable.RowCount = 1;
                categoryTable.RowStyles[categoryTable.RowCount - 1].Height = 40;
                foreach (DataRow row in dataTable.Rows)
                {
                    categoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                    categoryTable.RowCount += 1;
                    Label label0 = new()
                    {
                        Text = row["productCategory"].ToString()!,
                    };

                    Label label1 = new()
                    {
                        Text = row["inStock"].ToString()!,
                    };

                    categoryTable.Controls.Add(label0, 0, categoryTable.RowCount - 1);
                    categoryTable.Controls.Add(label1, 1, categoryTable.RowCount - 1);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.conn.Close();
        }
    }
}
