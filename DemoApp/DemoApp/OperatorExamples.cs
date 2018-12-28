using System;

namespace DemoApp
{
    class OperatorExamples
    {
        private int a;
        private int b;
        private int c;

        public void Example()
        {

            a = 10;
            b = 10;

            // ++ incremental operator 

            c = ++a; // increase and then assign
            Console.WriteLine("value of a = {0}, c = {1}", a, c);

            c = a++; // assign and than increase
            Console.WriteLine("value of a = {0}, c = {1}", a, c);

            c = --b;// decrease and then assign
            Console.WriteLine("value of b = {0}, c = {1}", b, c);

            c = b--;// assign and than decrease
            Console.WriteLine("value of b = {0}, c = {1}", b, c);
        }

        public void SingleConditinalOperators()
        {
            //a == b this will always return bool like true or false
            // conditional statement

            if (a == b)
            { // test criteria
                Console.WriteLine("a is equal to b");
            }
            else
            {
                Console.WriteLine("a is not equal to b");
            }


            if (a != b) { } // a is not equal to b

            if (a > b) { }

            if (a >= b) { }

            if (a < b) { }

            if (a <= b) { }
        }

        public void MultiConditionalOperators() {

            // true and true -> true
            // true and false -> false
            // false and true  -> false
            // false and false -> false

            if (a > b && b < c) { } // in order to make this truth both condition needs to be true;

            if (a > b || b < c) { } // either of them should be true
        }
    }
}
