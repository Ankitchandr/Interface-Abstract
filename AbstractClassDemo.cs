using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace AbstractionClassOrMethod
{
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Manager obj = new Manager();
            obj.GetEmployeeDetails();
            obj.DisplayDetails();
            Console.Read();
        }
        public void logDemo(string data, string msgType)
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(AbstractClassDemo));
            if (msgType == "success")
            {
                log.Info(data);
            }
            else if (msgType == "error")
            {
                log.Error(data);
            }
        }

        public abstract class Employee : AbstractClassDemo
        {
            public int Eno;
            public double salary;
            public string Name, Address;

            public abstract void GetEmployeeDetails();
            public virtual void DisplayDetails()
            {
               
                Console.WriteLine("Employee Details", "success");
                Console.WriteLine("Eno = ", "success" + this.Eno);
                Console.WriteLine("Name = ", "success" + this.Name);
                Console.WriteLine("Address = ", "success" + this.Address);
                Console.WriteLine("Salary= ", "success" + this.salary);
            }

        }

        public class Manager : Employee 
        {
            public double Bonus;

            public override void GetEmployeeDetails()
            {
                logDemo("Enter Employee Details", "success");
                logDemo("Enter Employee no", "success");
                Eno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee name", "success");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Address", "success");
                Address = Console.ReadLine();
                Console.WriteLine("Enter Employee salary", "success");
                salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Employee Bonus", "success");
                Bonus = Convert.ToDouble(Console.ReadLine());
            }

           
            public override void DisplayDetails()
            {
                
                logDemo("Manager Details", "success");
                Console.WriteLine("Manager Id= " + Eno);
                Console.WriteLine("Manager Name= " + Name);
                Console.WriteLine("Manager  Salary= " + salary);
                Console.WriteLine("Manager Bonus= " + Bonus);
                Console.WriteLine("Manager Address= " + Address);


            }

        }



    }
}
