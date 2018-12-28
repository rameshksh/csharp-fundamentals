using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class VariableExamples
    {
        // declaring Global variable at class level which can be accessed inside any method

        // properties 
        public int Id { get; set; }

        public string Name { get; set; } // Global variable to class

        public static int Salary { get; set; } // Remind to explain later on

        VariableExamples() {
            this.Name = "test";
        }

        // methods

        void Display() 
        {
            // inside this method we have local scope defined means we can use variable inside this method only
            // we can have only one variable with same name

            int age; // declaring

            age = 30; // assgining

            int age1 = 30; // declaring and assgin

            string Name1 = this.Name;  // this is local variable to method


            // this is Global variables
            this.Name = "Venkat";
        }

        void Display1()
        {
            this.Name = "Ramesh";
            string Name2 = this.Name;  // this is local variable to method
        }

        void Display2()
        {
            string Name3 = this.Name;  // this is local variable to method

        }
    }
}
