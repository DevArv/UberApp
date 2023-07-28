using CarNS;
using AccountNS;

namespace CarTypes.UberBlack
{
    public class UberBlack : Car
    {
        Dictionary<string, Dictionary<string, int>> typeCarAccepted;
        private List<string> seatsMaterial;

        public UberBlack(string License, Account Driver, Dictionary<string, Dictionary<string, int>> typeCarAccepted,
        List<string> seatsMaterial) : base(License, Driver)
        {
            this.typeCarAccepted = typeCarAccepted;
            this.seatsMaterial = seatsMaterial;
        }
    }
}