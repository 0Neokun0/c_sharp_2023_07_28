using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 27;
            string name = "Nishant";
            string job = "Technology Consultant";

            // 1. string concatenation
            Console.WriteLine("String Conctenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old ");

            // 2. String formatting
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old and i am {2}", name, age, job);
                 
        }
    }
}