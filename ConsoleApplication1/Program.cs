using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter your name please:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            string Age = Console.ReadLine();
            Console.WriteLine("your Contact:");
            string Contact = Console.ReadLine();
            Console.WriteLine(Environment.NewLine+"Here is your information:" + Environment.NewLine + 
                "Name:" + name + Environment.NewLine + "Address:" + Address + Environment.NewLine + 
                "Age:" + Age+ Environment.NewLine + "Contact no:" + Contact);
                               
            Console.ReadKey();

        }
    }
}
