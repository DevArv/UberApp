using CarNS;
using AccountNS;

namespace CarTypes.UberXCar
{
    public class UberX : Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public UberX(string License, Account Driver, string brand, string model) : base(License, Driver)
        {
            this.Brand = brand;
            this.Model = model;
        }
    }

}