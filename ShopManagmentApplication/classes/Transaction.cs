using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
