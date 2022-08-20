using System;
using ShopManagementApp.database;
using ShopManagementApp.screens;
using MySql.Data.MySqlClient;
using static System.Console;
namespace ShopManagementApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new Login());
        }
    }
}