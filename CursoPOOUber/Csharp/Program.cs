using System.Data.Common;
using CarNS;

namespace UberApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car = new Car("LICDEMO001", "Nathaly Diaz");
            {
                car.Id = 1;
                car.Passengers = 4;
            }
            car.PrintDataCar();
        }
    }
}