using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};

            List<string> fruitsList = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"};

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();// Start Method
            
            foreach(var fruit in fruitsArray) //it is  to calculated total time taken by array.
            {
                Console.WriteLine(fruit);
            }

            stopWatch.Stop();// time stopping method
            System.Console.WriteLine($"Total time it took is  {stopWatch.ElapsedMilliseconds} milsecs");//this method will calculate the time taken by each array.  

        }
    }
}
