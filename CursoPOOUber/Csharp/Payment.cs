using System;

namespace PaymentTypes
{

    //Definition of the "Payment" class.
    public class Payment
    {

        //Attributes
        public int Id { get; set; }

        public Payment(int id)
        {
            this.Id = id;
        }

        public void PrintPaymentData()
        {
            Console.WriteLine("This is the ID of this payment: " + Id);
        }
    }
}