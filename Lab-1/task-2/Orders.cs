using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labTask1
{
    class Orders
    {
        private int OrderNumber;

        public int OrderNumber1
        {
            get { return OrderNumber; }
            set { OrderNumber = value; }
        }

        public string OrderDate1
        {
            get { return OrderDate; }
            set { OrderDate = value; }
        }

        private string OrderDate;
        private Customers cObj;

        public Orders(int orderNumber, string orderDate, Customers cObj)
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
            this.cObj = cObj;
        }

        public void DisplayOrder()
        {
            Console.WriteLine("user id");
            Console.WriteLine(cObj.Numbers1);
            Console.WriteLine("user Orde numberr");
            Console.WriteLine(this.OrderNumber1);
            Console.WriteLine("user order date");
            Console.WriteLine(this.OrderDate1);

        }

    }
}
