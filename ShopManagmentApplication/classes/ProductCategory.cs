using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementApplication.classes
{
    internal class ProductCategory
    {
        public ProductCategory(string category, int numberOfItems)
        {
            this.category = category;
            this.numberOfItems = numberOfItems;
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


    }
}
