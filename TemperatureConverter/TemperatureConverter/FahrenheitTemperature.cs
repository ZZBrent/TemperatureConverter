using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class FahrenheitTemperature
    {
        public double measurement { get; set; }

        public FahrenheitTemperature(double temp)
        {
            measurement = temp;
        }

        public static explicit operator CelsiusTemperature(FahrenheitTemperature fTemp)
        {
            CelsiusTemperature cTemp = new CelsiusTemperature((fTemp.measurement - 32) * 0.5556);
            return cTemp;
        }
    }
}
