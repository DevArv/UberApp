using CarNS;
using AccountNS;

namespace CarTypes.UberXCar
{
    public class UberX : Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public UberX(string License, Account Driver, string Brand, string Model) : base(License, Driver)
        {
            this.Brand = Brand;
            this.Model = Model;
        }
    }

}