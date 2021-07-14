using System;

namespace Miles_per_gallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven;
            double fuelConsumed;
            double mpg;
            string input;

            Console.WriteLine("Enter the total miles driven.");
            input = Console.ReadLine();
            milesDriven = double.Parse(input);
            Console.WriteLine("Enter the total amount of fuel consumed.");
            input = Console.ReadLine();
            fuelConsumed = double.Parse(input);
            mpg = milesDriven / fuelConsumed;
            Console.WriteLine("The miles per gallon is " + mpg + ".");

        }
    }
}
