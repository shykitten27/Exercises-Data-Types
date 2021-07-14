using System;

namespace Area_of_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleLength;
            double rectangleWidth;
            double rectangleArea;
            string input;

            Console.WriteLine("Enter the length of rectangle.");
            input = Console.ReadLine();
            rectangleLength = double.Parse(input);
            Console.WriteLine("Enter the width of rectangle.");
            input = Console.ReadLine();
            rectangleWidth = double.Parse(input);
            rectangleArea = rectangleLength * rectangleWidth;
            Console.WriteLine("The area of a rectangle " + rectangleLength + " in length and " + rectangleWidth + " in width is " + rectangleArea + ".");
        }
    }
}
