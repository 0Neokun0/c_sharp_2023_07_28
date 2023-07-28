public class DataTypesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;
            // declaring multiple variables at once
            int num3, num4, num5;
            // assigning a value to a variable
            num1 = 13;
            int num2 = 14;

            int sum = num1 + num2;
            Console.WriteLine("num1 " + num1 + " num2 " + num2 + " is " + sum);

            // Double
            double d1 = 3.23434;
            double d2 = 5.3;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            // Float
            float f1 = 3.233f;
            float f2 = 4.5f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            // interchanging datatypes
            double dDDiv = d1 / num1;
            Console.WriteLine(dDDiv);
            Console.Read();

        }
    }
}