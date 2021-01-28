using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Car
    {
        public string CarName { get; private set; }
        public DateTime Year { get; private set; }

        public Car(string carName, DateTime year)
        {
            CarName = carName;
            Year = year;
        }
    }
}
