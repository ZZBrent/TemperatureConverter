using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Start();
        }

        static void Start()
        {
            Console.Write("Input a temperature followed by an F for Fahrenheit or a C for Celsius: ");
            string input = Console.ReadLine().ToUpper();
            FahrenheitTemperature fTemp;
            CelsiusTemperature cTemp;
            switch (input[input.Length - 1])
            {
                case 'F':
                    input = input.TrimEnd('F');
                    if (Double.TryParse(input, out double fTempValue))
                    {
                        fTemp = new FahrenheitTemperature(fTempValue);
                        cTemp = (CelsiusTemperature)fTemp;
                        Output(fTemp, cTemp);
                    }
                    else
                        invalidInput();
                    break;
                case 'C':
                    input = input.TrimEnd('C');
                    if (Double.TryParse(input, out double cTempValue))
                    {
                        cTemp = new CelsiusTemperature(cTempValue);
                        fTemp = (FahrenheitTemperature)cTemp;
                        Output(fTemp, cTemp);
                    }                        
                    else
                        invalidInput();
                    break;
                default:
                    invalidInput();
                    break;
            }
        }

        static void Output(FahrenheitTemperature fTemp, CelsiusTemperature cTemp)
        {
            Console.WriteLine(String.Format("The current temperature in Cesuis is {0}\u00B0C", round(cTemp.measurement)));
            Console.WriteLine(String.Format("The current temperature in Fahrenheit is {0}\u00B0F", round(fTemp.measurement)));
            Console.WriteLine(@"Would you like to make another conversion? (Y/N)");
            string input = Console.ReadLine().ToUpper();
            if (input == "Y" || input == "YES")
                Start();
        }

        static void invalidInput()
        {
            Console.WriteLine("Your input is invalid.  Please try again.");
            Start();
        }

        static double round(double d)
        {
            return Math.Truncate(d * 10) / 10;
        }
    }
}
