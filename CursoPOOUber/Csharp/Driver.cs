using AccountNS;

namespace DriverDetails
{
    //Definition of the child "Driver" class, which inherits from "Car" class.
    public class Driver : Account
    {
        public Driver(string name, string document) : base (name, document)
        {

        }

        //This method is overwriting the method assigned in its parent class.
        public override void PrintDataDriver() {
            base.PrintDataDriver();
        }        
    }
}