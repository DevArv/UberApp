using CarNS;
using AccountNS;

namespace CarTypes.UberBlack
{
    public class UberBlack : Car
    {
        Dictionary<string, Dictionary<string, int>> TypeCarAccepted;
        private List<string> SeatsMaterial;

        public UberBlack(string License, Account Driver, Dictionary<string, Dictionary<string, int>> typeCarAccepted,
        List<string> seatsMaterial) : base(License, Driver)
        {
            this.TypeCarAccepted = typeCarAccepted;
            this.SeatsMaterial = seatsMaterial;
        }
    }
}