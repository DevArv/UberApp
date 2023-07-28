using CarNS;
using AccountNS;

namespace CarTypes.UberPool 
{
    public class UberPool : Car 
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public UberPool(string License, Account Driver, string Brand, string Model) : base(License, Driver) {
            this.Brand = Brand;
            this.Model = Model;
        }
    }
}