using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            var myname = " Katie Ricks";
            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(2017, 12, 25);
            TimeSpan difference = christmas - today;
            //test
            Console.WriteLine($"Hello World!");
            Console.WriteLine($"Katie Ricks");
            Console.WriteLine($"Rexburg, Idaho");
            Console.WriteLine($"Hello " + $"{myname}!");
            Console.WriteLine($"The current date is: " + today);
            
            Console.WriteLine($"Time until Christmas: " + difference.ToString("dd") + " days!");


            //Program from Book
            Console.WriteLine($"\n");
            Console.WriteLine("Please Enter Width of Window in Meters.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);


            Console.WriteLine("Please Enter Height of Window in Meters.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");

            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadLine();
        }
    }
}
