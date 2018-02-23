using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{

    
    class Program
    {
        public void take_input()
        {
           ArrayList list = new ArrayList();

            string[] array = new string[5];

            //input array loop
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            ////print array loop
            foreach (string loop in array)
            {
                Console.Write(loop + " ");

            }
            //while loop
            Console.WriteLine("While loop");
            int inc=0;
            while ( inc!=5)
             {
                Console.WriteLine(array[inc]);

                inc++;
            }
            //ARRAY LIST INPUT
            list.Add(5);
            list.Add(7);
            list.Add("dsa");

            print_Arraylist(list);
            /////


        }
        public void print_Arraylist(ArrayList list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        public class Base
        {

            public virtual void Show()
            {
                Console.WriteLine("Show From Base Class.");
            }
        }

        public class Derived : Base
        {
            public override void Show()
            {
                Console.WriteLine("Show From Derived Class.");
            }
        }
        public class SecondDerived : Base
        {
            public override void Show()
            {
                Console.WriteLine("Show From Second Derived Class");
            }
        }
        static void Main(string[] args)
        {
            ////object initial
            Program objP=new Program();
            //array input
            objP.take_input();
            //array_list
            Student objS = new Student();
            ///inheritence
            objS.set_info();
            objS.print_info();

            ///Polymorphism
            Base objBase;
            objBase = new Base();
            objBase.Show();//    Output ----> Show From Base Class.

            objBase = new Derived();
            objBase.Show();//Output--> Show From Derived Class.

            objBase = new SecondDerived();
            objBase.Show();//Output---> Show From Second Derived Class.



        }
    }
}
