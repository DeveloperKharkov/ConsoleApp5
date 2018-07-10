using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16HomeWork
{
    static class TemeratureConveror
    {
        public static float FromCelsiusToKelvin(float value)
        {
            return value + 273.15f;
        }

        public static float FromKelvinToCelsius(float value)
        {
            return value - 273.15f;
        }

        public static float FromCelsiusToFahrenheit(float value)
        {
            return value*1.8f + 32;
        }

        public static float FromFahrenheitToCelsius(float value)
        {
            return (32 - value) / 1.8f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input value which you want to convert:");
            float inputValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Please choose the operation:");
            Console.WriteLine("1 - FromCelsius To Kelvin");
            Console.WriteLine("2 - FromKelvin To Celsius");
            Console.WriteLine("3 - FromCelsius To Fahrenheit");
            Console.WriteLine("4 - FromFahrenheit To Celsius");

            byte operation = byte.Parse(Console.ReadLine());
            float result;
            switch(operation)
            {
                case 1:
                    result = TemeratureConveror.FromCelsiusToKelvin(inputValue);
                    break;
                case 2:
                    result = TemeratureConveror.FromKelvinToCelsius(inputValue);
                    break;
                case 3:
                    result = TemeratureConveror.FromCelsiusToFahrenheit(inputValue);
                    break;
                case 4:
                    result = TemeratureConveror.FromFahrenheitToCelsius(inputValue);
                    break;
                default:
                    throw new Exception($"the operation='{operation}' is unsupported");
            }

            Console.WriteLine($"Result after conversion equal to {result}");
        }
    }
}
