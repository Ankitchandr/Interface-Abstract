using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUse
{
    interface interface1
    {
        void Test();
        void Show();

    }
    interface interface2
    {
        void Test();
        void Show();

    }

    class MultipleInheritance:interface1,interface2
    {
        static void Main(string[] args)
        {
            MultipleInheritance obj = new MultipleInheritance();
            obj.Test();
            interface1 I1 = obj;
            I1.Show();
            interface2 I2 = obj;
            I2.Show();
            Console.Read();
        }

        public void Test()
        {
            Console.WriteLine("Interface method is  implemented in child class");
        }

        void interface2.Show()
        {
            Console.WriteLine("Interface1 show method is  implemented  explicitly in child class");
        }

        void interface1.Show()
        {
            Console.WriteLine("Interface2  show method is  implemented explicitly in child class");
        }

      
    }
}
