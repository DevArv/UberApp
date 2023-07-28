using CarNS;
using AccountNS;

namespace CarTypes.UberPool 
{
    public class UberPool : Car 
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public UberPool(string License, Account Driver, string brand, string model) : base(License, Driver) {
            this.Brand = brand;
            this.Model = model;
        }
    }
}