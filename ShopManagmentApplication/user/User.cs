using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApp
{
    internal class User
    {
        private string fName;

        public string FName
        {
            get { return fName; }
            set => this.fName = value;
        }

        private string lName;

        public string LName
        {
            get { return lName; }
            set => this.lName = value;
        }

        private string shopName;

        public string ShopName
        {
            get { return shopName; }
            set => this.shopName = value; 
        }

        public User()
        {
            this.fName = string.Empty;
            this.lName = string.Empty;
            this.shopName = string.Empty;
        }

        public User(string fName, string lName,  string shopName)
        {
            this.fName = fName;
            this.lName = lName;
            this.shopName = shopName;
        }
    }
}
