using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopManagementApplication.database;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace ShopManagementApplication.classes
{
    internal class User
    {
        private DatabaseConnection connection;
        public User(string firstNames, string lastName, string gender, string username, string role, string dob, string email, string password, string phone, bool privileged)
        {
            this.firstNames = firstNames;
            this.lastName = lastName;
            this.gender = gender;
            this.role = role;
            this.dob = DateOnly.Parse(dob, new System.Globalization.CultureInfo("fr-FR"));
            this.email = email;
            this.username = username;
            this.phone = phone;
            this.password = password;
            this.privileged = privileged;
        }

        public User(string firstNames, string lastName, string gender, string username, string role, string dob, string email, string phone, bool privileged)
        {
            this.firstNames = firstNames;
            this.lastName = lastName;
            this.gender = gender;
            this.role = role;
            this.dob = DateOnly.Parse(dob, new System.Globalization.CultureInfo("fr-FR"));
            this.email = email;
            this.username = username;
            this.phone = phone;
            this.privileged = privileged;
        }

        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }


        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        private string firstNames;

        public string FirstNames
        {
            get { return firstNames; }
            set { firstNames = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        private DateOnly dob;

        public DateOnly Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        private string photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

       
        private bool privileged;

        public bool Privileged
        {
            get { return privileged; }
            set { privileged = value; }
        }

        override
        public string ToString()
        {
            return String.Format("{0,-20}{1,-25}{2,-20}{3,-20}{4,-20}{5,-20}{6,-8}{7}", "|" + firstNames, "|" + email, "|" + gender, "|" + phone, "|" + role, "|" + dob, "|" + privileged, "|");
        }


        public void CreateUser()
        {
            connection = new();
            WriteLine(dob);
            String insertQuery = $"INSERT INTO users(lastName, firstNames, role, username, dob, email, password, phone, gender, privileged)" +
                                $" VALUES('{LastName}','{FirstNames}','{role}', '{ Username}', STR_TO_DATE('{dob}','%m/%d/%Y'),'{Email}','{password}','{Phone}','{gender}',{Privileged})";
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

        public void UpdateUser()
        {
            connection = new();
            string updateQuery = $"UPDATE users SET firstNames ='{FirstNames}', lastName = '{LastName}', email='{Email}'," +
                $" dob=STR_TO_DATE('{Dob}','%m/%d/%Y'), phone='{Phone}', gender='{Gender}', role = '{Role}'" +
                $" WHERE username='{Username}'";

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

        public static void RemoveUser(string username)
        {
            DatabaseConnection connection = new();
            string removeQuery = $"DELETE FROM users WHERE username = '{username}'";
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

        public static void ViewUsers(TableLayoutPanel usersTable)
        {
            DatabaseConnection connection = new();
            string selectQuery = $"SELECT * FROM users";
            try
            {
                MySqlCommand cmd = new(selectQuery, connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new();
                dataTable.Load(reader);
                usersTable.RowCount = 1;
                usersTable.RowStyles[usersTable.RowCount-1].Height = 40;
                foreach (DataRow row in dataTable.Rows)
                {
                    usersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                    usersTable.RowCount += 1;
                    Label label0 = new()
                    {
                        Text = row["lastName"].ToString()!,
                    };

                    Label label7 = new()
                    {
                        Text = row["firstNames"].ToString()!,
                    };

                    Label label8 = new()
                    {
                        Text = row["username"].ToString()!,
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

                    usersTable.Controls.Add(label0, 0, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label5, 5, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label7, 1, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label3, 6, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label8, 2, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label2, 4, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label1, 3, usersTable.RowCount - 1);
                    usersTable.Controls.Add(label4, 7, usersTable.RowCount - 1);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
                ReadKey();
            }
        }

        public static User? GetUser(string username)
        {
            DatabaseConnection connection = new();
            string selectQuery = $"SELECT * FROM users WHERE username = '{username}'";
            try
            {
                MySqlCommand cmd = new(selectQuery, connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DateTime date = DateTime.ParseExact(reader["dob"].ToString()!, "M/d/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    string dateString = date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    return new User(reader["firstNames"].ToString()!, reader["lastName"].ToString()!, reader["gender"].ToString()!,
                        "wonder", reader["role"].ToString()!, dateString, reader["email"].ToString()!,
                        reader["password"].ToString()!, reader["phone"].ToString()!, bool.Parse(reader["privileged"].ToString()!));
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
