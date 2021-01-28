using System;
using System.Runtime.InteropServices;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> collection = new CarCollection<Car>();

            collection.Add(new Car("BMW", DateTime.Parse("01/05/2010")));
            collection.Add(new Car("AUDI", DateTime.Parse("05/12/2004")));
            collection.Add(new Car("SOME CAR NAME", DateTime.Parse("03/01/2020")));

            foreach (var car in collection)
            {
                Console.WriteLine($"Название: {car.CarName}, выпущен: {car.Year:Y}");      
            }
        }
    }
}
