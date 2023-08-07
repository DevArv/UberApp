using CarNS;
using AccountNS;

namespace CarTypes.UberVan
{

    //Definitions of the "UberVan" class, which inherits from "Car" class.
    public class UberVan : Car 
    {
        //The first "Dictionary" stores the brand and the second one represents the model.
        Dictionary<string, Dictionary<string, int>> TypeCarAccepted;
        //Car seats material.
        private List<string> SeatsMaterial;

        public UberVan(string License, Account Driver, Dictionary<string, Dictionary<string,int>> typeCarAccepted,
            List<string> seatsMaterial) : base(License, Driver)
    {
        this.TypeCarAccepted = typeCarAccepted;
        this.SeatsMaterial = seatsMaterial;
    }

        public void PrintUberVanData() {
            Console.WriteLine("Type Car Accepted: " + TypeCarAccepted + " Seats Material: " + SeatsMaterial);
        }

    }
}