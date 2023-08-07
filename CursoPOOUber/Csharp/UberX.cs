using CarNS;
using AccountNS;

namespace CarTypes.UberXCar
{
    //Definition of the "UberX" class, which inherits from the "Car" class.
    public class UberX : Car
    {
        
        //Attributes
        public string Brand { get; set; }
        public string Model { get; set; }

        public UberX(string License, Account Driver, string brand, string model) : base(License, Driver)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public void PrintUberxData() {
            Console.WriteLine("Car Brand: " + Brand + " Uberx Model: " + Model);
        }
    }
}