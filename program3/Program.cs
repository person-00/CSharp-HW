using System;
using System.Net.NetworkInformation;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            double input1 = 0;
            double input2 = 0;

            Console.WriteLine("what is the radius of the cylinder: ");
            userInput = Console.ReadLine();
            input1 = double.Parse(userInput);

            Console.WriteLine("what is the height of the cylinder: ");
            userInput = Console.ReadLine();
            input2 = double.Parse(userInput);

            double pi = 3.14159;
            double square = Math.Pow(input1, 2);
            double volume = (square * input2 * pi);
            double area = (2 * pi * square + 2 * input1 * input2);

            Console.WriteLine("The volume is: "+volume);
            Console.WriteLine("The area is: "+area);
            Console.Read(); 



        }
    }
}
