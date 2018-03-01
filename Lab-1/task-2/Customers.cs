using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask1
{
    class Customers
    {
        private int Numbers;

        public int Numbers1
        {
            get { return Numbers; }
            set { Numbers = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string name;


        public Customers(int numbers, string name)
        {
            Numbers = numbers;
            this.name = name;
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("User ID");
            Console.WriteLine(this.Numbers1);
            Console.WriteLine("User Name");
            Console.WriteLine(this.Name);
        }
    }
}
