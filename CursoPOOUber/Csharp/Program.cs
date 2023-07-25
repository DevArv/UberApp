using CarNS;

namespace UberApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = 1;
            car.License = "PRUEBA01";
            car.Driver = "Nathaly Diaz";
            car.Passengers = 4;

            Car car2 = new Car();
            car2.Id = 2;
            car2.License = "PRUEBA02";
            car2.Driver = "Ana Lucia";
            car2.Passengers = 4;

            car.PrintDataCar();
            car2.PrintDataCar();
        }
    }
}