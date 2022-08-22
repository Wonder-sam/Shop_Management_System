using System;
using ShopManagementApplication.database;
using ShopManagementApplication.screens;
using MySql.Data.MySqlClient;
using static System.Console;
namespace ShopManagementApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new Login());
        }
    }
}