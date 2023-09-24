using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WeatherData: A tuple with elements for the temperature, humidity, and wind speed of a weather reading.

namespace N36_HT2.Models
{
    public class WeatherDate
    {
        static void Main()
        {
            var weatherDate = (36, 12, 25);

            var temperature = weatherDate.Item1;
            var humidity = weatherDate.Item2;
            var windSpeed = weatherDate.Item3;

            Console.WriteLine("Wether temperature : " + temperature);
            Console.WriteLine("Wether humidity : " + humidity);
            Console.WriteLine("Wether wind speed : " + windSpeed);
        }
    }
}
