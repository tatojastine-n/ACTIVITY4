using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelingHotOrCold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float celsius;
            bool isValidInput;

            do
            {
                Console.Write("Enter temperature in Celsius (-100 to 100): ");
                isValidInput = float.TryParse(Console.ReadLine(), out celsius) && celsius >= -100 && celsius <= 100;
                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Enter a number between -100 and 100.");
                }
            } while (!isValidInput);
            float fahrenheit = (celsius * 9f / 5f) + 32;
            Console.WriteLine( $"Temperature in Fahrenheit: {fahrenheit.ToString("0.##")}"); 
        }
    }
}
