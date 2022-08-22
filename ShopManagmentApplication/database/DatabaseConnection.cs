using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ShopManagementApplication.database
{
    internal class DatabaseConnection
    {
        public MySqlConnection conn = new();
        public DatabaseConnection()
        {
            try
            {
                String connectionString = "server=localhost;port=3306;database=shoprite;uid=root;pwd=Mysqlpass@3306";
                this.conn.ConnectionString = connectionString;
                //open connection
                conn.Open();
            }
            catch (Exception e)
            {
                WriteLine("Oops!");
                WriteLine(e.Message);
                ReadKey();
            }

        }
    }
}
