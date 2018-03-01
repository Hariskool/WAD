using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask1
{
    class Products
    {
        private OrderDetails odObj;
        private string productName;

        public Products(OrderDetails odObj, string productName)
        {
            this.odObj = odObj;
            this.productName = productName;
        }

        public OrderDetails OdObj
        {
            get { return odObj; }
            set { odObj = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        void DisplayProducts()
        {
            Console.WriteLine("user product number");
            Console.WriteLine(odObj.ProducNumbers);
            Console.WriteLine("user product name");
            Console.WriteLine(this.ProductName);
        }
    }
}
