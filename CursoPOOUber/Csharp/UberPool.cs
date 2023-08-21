using CarNS;
using AccountNS;

namespace CarTypes.UberPool 
{

    //Definition of the "UberPool" class, which inherits from "Car" class.
    public class UberPool : Car 
    {

        //Attributes
        public string Brand { get; set; }
        public string Model { get; set; }

        public UberPool(string License, Account Driver, string brand, string model) : base(License, Driver) 
        {
            this.Brand = brand;
            this.Model = model;
            SetPassengers(4);
        }

        public override void PrintDataCar()
        {
            base.PrintDataCar();
            Console.WriteLine("Car Brand: " + Brand + " UberPool model: " + Model);
        }
    }
}