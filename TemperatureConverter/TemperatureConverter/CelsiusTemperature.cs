using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class CelsiusTemperature
    {
        public double measurement { get; set; }

        public CelsiusTemperature(double temp)
        {
            measurement = temp;
        }

        public static explicit operator FahrenheitTemperature(CelsiusTemperature cTemp)
        {
            FahrenheitTemperature fTemp = new FahrenheitTemperature((cTemp.measurement / 0.5556) + 32);
            return fTemp;
        }
    }
}
