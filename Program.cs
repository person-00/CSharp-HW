using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the 3rd number: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the 4th number: ");
            decimal num4 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the 5th number: ");
            decimal num5 = Convert.ToDecimal(Console.ReadLine());

            decimal sum = num1 + num2 + num3 + num4 + num5;
            decimal avg = sum / 5;
            Console.WriteLine("The average is " + avg);
            Console.Read();
        }
    }
}






