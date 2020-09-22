using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            var name = "Cesar";
            var location = "Rexburg, ID";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I'm from {location}");
            var today = DateTime.Now;
            var date = DateTime.Now.ToShortDateString();
            Console.WriteLine("Current date: {0}", date);

            DateTime christmas = new DateTime(today.Year,12,25);
            var daysToChristmas = (christmas.Date - today.Date).Days;

            Console.WriteLine("Days until christmas from today: {0}", daysToChristmas);


            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }
    }

}
