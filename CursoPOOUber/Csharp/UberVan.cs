using CarNS;
using AccountNS;

namespace CarTypes.UberVan
{
    public class UberVan : Car 
{
    Dictionary<string, Dictionary<string, int>> typeCarAccepted;
    List<string> seatsMaterial;

    public UberVan(string License, Account Driver, Dictionary<string, Dictionary<string,int>> typeCarAccepted,
    List<string> seatsMaterial) : base(License, Driver)
    {
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }
}
}