using System.Data.Common;
using CarNS;
using AccountNS;
using CarTypes.UberXCar;

namespace UberApp
{

    //Definition of the class that control the UberApp.
    class MainClass
    {
        public static void Main(string[] args)
        {
            // var car = new Car("LICDEMO001", "Nathaly Diaz");
            // {
            //     car.Id = 1;
            //     car.Passengers = 4;
            // }
            // car.PrintDataCar();

            Console.WriteLine("Starting Process...");

            Console.WriteLine("Customer requesting a car...");
            var car = new Car("LICDEMO01", new Account("Joan Alexander", "DOCDEMO01"));
            {
                car.PrintCustomerData();
            }

            Console.WriteLine("Requesting an UberX");

            Console.WriteLine("UberX requested");
            var uberX = new UberX("LICDEMO02", new Account("Nathaly Diaz", "DOCDEMO02"), "Hyundai", "I10");
            {
                uberX.Passengers = 4;
                uberX.PrintDataCar();
                uberX.PrintUberxData();
            }

        }
    }
}