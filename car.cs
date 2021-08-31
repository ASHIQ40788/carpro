using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp058
{
    class Car
    {
        string color = "SKYBLUE";
        int model = 40788;
        public void Drive()
        {
            Console.WriteLine("Driving");

        }
        public static void Brake()
        {
            Console.WriteLine("Brake");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.model);
            myObj.Drive();
            Car.Brake();
            Console.Read();
        }
    }
}
