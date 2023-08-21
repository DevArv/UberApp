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
            SetPassengers(4);
        }

        public override void PrintDataCar()
        {
            base.PrintDataCar();
            Console.WriteLine("Car Brand: " + Brand + " UberX model: " + Model);
        }
    }
}