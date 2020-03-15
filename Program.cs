using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
        }
        static void Test()
        {
            Console.WriteLine("This is a method");

            /* Variables and Data types */
            string firstName = "Sandie";
            Console.WriteLine("My name is: " + firstName);

            int age = 99;
            long seconds = 123456789123456789;

            float price = 12.34f;
            decimal price2 = 123.23m;  // usually decimals are used for money

            bool isThisCrazy = true;

            // if statements
            if(isThisCrazy)
            {
                Console.WriteLine("Yeah it is");
            }
            else
            {
                Console.WriteLine("No it isn't");
            }

            // loops
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }
        }
    }
}
