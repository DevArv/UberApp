using CarNS;
using AccountNS;

namespace CarTypes.UberVan
{
    public class UberVan : Car 
{
    Dictionary<string, Dictionary<string, int>> TypeCarAccepted;
    List<string> SeatsMaterial;

    public UberVan(string License, Account Driver, Dictionary<string, Dictionary<string,int>> typeCarAccepted,
    List<string> seatsMaterial) : base(License, Driver)
    {
        this.TypeCarAccepted = typeCarAccepted;
        this.SeatsMaterial = seatsMaterial;
    }
}
}