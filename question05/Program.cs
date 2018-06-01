using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            var number =Int32.Parse(Console.ReadLine());

            
            for(int a = 0; a <= 9; a++) {
                
                Console.WriteLine($"{a} / {number} = {a / number}");
                
                
            }
        }
    }
}


            
                
      