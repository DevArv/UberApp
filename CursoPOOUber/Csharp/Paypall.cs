using PaymentTypes;

namespace PaymentTypes.Paypall 
{

    //Definition the "Paypall" class, which inherits from "Payment" class.
    public class Paypall : Payment 
    {

        //Attributes.
        public string Email { get; set; }


        public Paypall(int id, string email) : base(id)
        {
            this.Id = id;
            this.Email = email;
        }

        public void PrintPaypallData()
        {
            Console.WriteLine("This is the email of the paypall account of this user: " + Email);
        }
    }
}