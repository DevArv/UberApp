public class UberX : Car
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public UberX(string License, Account Driver, string Brand, string Model) : base(License, Driver)
    {
        Brand = Brand;
        Model = Model;
    }
}