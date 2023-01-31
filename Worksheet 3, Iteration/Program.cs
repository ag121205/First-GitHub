using System;

namespace Worksheet_3__Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;

            string[] name = { "Hello", "Goodbye", "Goodmorning", "Goodnight" };

            for(counter = 0; counter <=3; counter++)
            {
                Console.WriteLine(name[counter]);
            }
            
        }
    }
}
