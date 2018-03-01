
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask1
{
    class OrderDetails
    {
        private Orders oObj;

        public int ProducNumbers
        {
            get { return producNumbers; }
            set { producNumbers = value; }
        }

        private int producNumbers;

        public OrderDetails(Orders oObj, int producNumbers)
        {
            this.oObj = oObj;
            this.producNumbers = producNumbers;
        }

        public void DisplayOrdersDetails()
        {
            Console.WriteLine("User order number");
            Console.WriteLine(oObj.OrderNumber1);
            Console.WriteLine("User Product number");
            Console.WriteLine(this.ProducNumbers);

        }

    }
}
