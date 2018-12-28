using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World Venkat!");

            // we need to declare a variable and assign value by calling method
            int sal = CalculateSalary(1000, 500);

           // Console.WriteLine("Venkat Salary - {0}, {2}", sal1, sal2, sal3);

            Console.WriteLine("Venkat Salary - " + sal);

           */

            int a = 30; // we are declaring variable of int data type
            string str = "test";

            OperatorExamples oe; // declaring a variable by class type

            oe = new OperatorExamples(); // we create object of a class.

            oe.Example(); // we call method of that class

            oe.SingleConditinalOperators();

            oe.MultiConditionalOperators();

            Console.ReadKey();
        }

        // We have just declared
        public static int CalculateSalary(int basic, int da) {
            return basic + da;
        }
    }
}
