using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    // We use arrays as a collection to store multiple variables with same primitive data type o class
    // Rules to follow
    /* 
     * 1> Same data type
     * 2> We need to specify size of Array(how many element it will store)
     * 3> or We need to create array by initilizing elements
     * 4> before accessing array we must initilize
     * 5> will throw exception if array doesn't initilized and accessed
     */

    class ArrayExamples
    {
        public void Practice() {
            int n = 10; // n is variable name

            int[] nbrs = new int[1]; // nbrs is variable name
            // it will store integers
            // it will store 10 integers
            // initially array will empty 

            int[] nbrs1 = new int[] { 1, 2, 34, 5 };
            // here size of array will be 4
            // initial value of array is assigned

            /*
             * nbrs1[0] = 1;
             * nbrs1[1] = 2;
             * nbrs1[2] = 34;
             * nbrs1[3] = 5;
             */

            // set
            nbrs[0] = 32;

            // get 
            int value = nbrs[0];

            // Using array index ( again integer value inside squre brackets) we can access elements
            // array index by default it will start at 0;

            //for(initilize ; condtion check ; increment ) { 

            //}

            // initlize ->  int i = 0; (this happens only first time) 
            // condition check (to terminate loop from executing or ending) -> i < nbrs.Length;  
            // increment -> i++

            //   0    1    2   3
            // | 23 | 4 | 5 | 67 |

            for (int i = 0; i < nbrs.Length; i++) // nbrs.Length -> count of elements in array
            {               
                Console.WriteLine("Elements in array nbrs at pos- {0}, value - {1}", i, nbrs1[i]);  // index and element
            }

            for (int i = 0; i < nbrs1.Length; i++)
            {
                Console.WriteLine("Elements in array nbrs1 at pos- {0}, value - {1}", i, nbrs1[i]);
            }

            // step
            /*
             * i = 0, 0 < 4
             * i = 1, 1 < 4
             * i = 2, 2 < 4
             * i = 3, 3 < 4
             * i = 4, 4 < 4   it is false and loop will stop
             */
        }
    }
}
