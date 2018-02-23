using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Student : Person
    {
        private Person Pobj;
        public string reg { get; set; }
        public string dept { get; set; }

       public  void set_info()
        {
            Console.WriteLine("input name");
            Pobj.name = Console.ReadLine();
            Console.WriteLine("input gender");
            Pobj.gender = Console.ReadLine();
            Console.WriteLine("input age");
            Pobj.age = int.Parse(Console.ReadLine());
            Console.WriteLine("input NIC");
            Pobj.NIC = int.Parse(Console.ReadLine());
            Console.WriteLine("input REG");
            reg = (Console.ReadLine());
            Console.WriteLine("input DEPT");
            dept = (Console.ReadLine());


        }

        public void print_info()
        {
            Console.WriteLine("*output*");
            Console.WriteLine(Pobj.name);
            Console.WriteLine(Pobj.date);
            Console.WriteLine(Pobj.gender);
            Console.WriteLine(Pobj.NIC);
            Console.WriteLine(reg);
            Console.WriteLine(dept);


        }

    }
}
