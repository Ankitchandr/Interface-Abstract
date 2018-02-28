using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionClassOrMethod
{


    class AbstractClassOrMethodExample
    {
        static void Main(string[] args)
        {
           
            Rectangle R= new Rectangle();
            R.draw();
 
            Circle c= new Circle();
            c.draw(); 
         
            Console.Read();
        }
    }


    public abstract class Shape
    {

        public abstract void draw();
     }

    public class Rectangle:Shape
    {
         
       public override void draw()
        {

            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(AbstractClassOrMethodExample));
            log.Info("Drawing Rectangle......");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(AbstractClassOrMethodExample));
            log.Info("Drawing Circle......");
        }

    }


}
