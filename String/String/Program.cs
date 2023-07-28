using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "Nishant";
            string message = "My name is " + myname;

            string cpasMessage = message.ToUpper();
            string lowerCaseMessage = message.ToLower();
            Console.WriteLine(lowerCaseMessage);
            Console.WriteLine(cpasMessage); 
            Console.WriteLine("My name is " + myname);
            Console.WriteLine(message);
        }
    }
}