using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- WeatherReport(State, Degree)

namespace WeatherReport_N39_HT1
{
    public class WeatherReport
    {
        public WeatherReport(string state, float degree)
        {
            State = state;
            Degree = degree;
        }

        public string State { get; set; }
        public float Degree { get; set; }

        public override string ToString()
        {
            return $"State : {State} Degree : {Degree}";
        }
    }
}
