using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICES_CodeFreeCamp
{
    class TemperatureConverter
    {
        public static void Run() 
        {
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine($"The temperature is {celsius} Celsius.");

        }    
    }
}
