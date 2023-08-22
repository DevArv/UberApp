using System.Data.Common;
using CarNS;
using AccountNS;
using CarTypes.UberXCar;
using PaymentTypes;
using PaymentTypes.CCard;

namespace UberApp
{

    //Definition of the class that control the UberApp.
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Starting Process...");

            Console.WriteLine("Customer requesting a car...");
            var car = new Car("LICDEMO01", new Account("Joan Alexander", "DOCDEMO01"));
            {
                car.SetPassengers(4);
                car.PrintDataCar();
            }

            Console.WriteLine("Requesting an UberX");

            Console.WriteLine("UberX requested");
            var uberX = new UberX("LICDEMO02", new Account("Nathaly Diaz", "DOCDEMO02"), "Hyundai", "I10");
            {
                uberX.GetPassengers();
                uberX.PrintDataCar();
            }

            Console.WriteLine("Method of payment...");

            Console.WriteLine("This user is paying with a credit card...");
            var ccard = new CCard(01, 0987654321, 312, DateTime.Now);
            {
                ccard.PrintCCardData();
            }
        }
    }
}