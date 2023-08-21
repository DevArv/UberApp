using CarNS;
using AccountNS;

namespace CarTypes.UberBlack
{

    //Definition of the "UberBlack" class, which inherits from "Car" class.
    public class UberBlack : Car
    {

        //The first "Dictionary" stores the brand and the second one represents the model.
        Dictionary<string, Dictionary<string, int>> TypeCarAccepted;
        //Car seats material.
        private List<string> SeatsMaterial;
        private int Passengers;

        public UberBlack(string License, Account Driver, Dictionary<string, Dictionary<string, int>> typeCarAccepted,
        List<string> seatsMaterial) : base(License, Driver)
        {
            this.TypeCarAccepted = typeCarAccepted;
            this.SeatsMaterial = seatsMaterial;
        }

        public override void SetPassengers(int passengers)
        {
            if(passengers == 4)
            {
                Passengers = passengers;
            }else{
                Console.WriteLine("This type of Uber is only for 4 passengers.");
            }
        }

        public override void PrintDataCar()
        {
            base.PrintDataCar();
            Console.WriteLine("License: " + License + " Driver: " + Driver.Name);
        }

    }
}