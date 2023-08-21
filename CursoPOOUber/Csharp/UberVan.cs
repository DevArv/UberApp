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
        private int Passengers;

    public UberVan(string License, Account Driver, Dictionary<string, Dictionary<string,int>> typeCarAccepted,
    List<string> seatsMaterial) : base(License, Driver)
    {
        this.TypeCarAccepted = typeCarAccepted;
        this.SeatsMaterial = seatsMaterial;
    }

    public override void SetPassengers(int passengers)
    {
        if(passengers == 6)
        {
            Passengers = passengers;
        }else {
            Console.WriteLine("This type of Uber is only for 6 passengers.");
        }
    }

        public override void PrintDataCar()
        {
            base.PrintDataCar();
            Console.WriteLine("License: " + License + " Driver: " + Driver.Name);
        }

    }
}