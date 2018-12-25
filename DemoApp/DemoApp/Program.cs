using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Venkat!");

            // we need to declare a variable and assign value by calling method
            int sal = CalculateSalary(1000, 500);

            Console.WriteLine("Venkat Salary - {0}", sal);

            Console.ReadKey();
        }

        // We have just declared
        public static int CalculateSalary(int basic, int da) {
            return basic + da;
        }
    }
}
