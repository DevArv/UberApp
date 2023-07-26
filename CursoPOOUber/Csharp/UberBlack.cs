using System.Collections.Generic;

public class UberBlack : Car
{
    Dictionary<string, Dictionary<string, int>> typeCarAccepted;
    List<string> seatsMaterial;

    public UberBlack(string license, Account Driver, Dictionary<string, Dictionary<string, int>> typeCarAccepted,
        List<string> seatsMaterial) : base(License, Driver)
    {
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }
}