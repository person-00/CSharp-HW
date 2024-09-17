using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            Console.WriteLine($"The length of the hypotenuse is {hypotenuse:F2}");
            Console.ReadLine();
        }
    }
}

