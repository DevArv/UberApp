using PaymentTypes;

namespace PaymentTypes.CCard
{

    //Definition of the "CCard" class. which inherits from "Payment" class.
    public class CCard : Payment
    {

        //Attributes
        public int Number { get; set; }
        public int CVV { get; set; }
        public DateTime Date { get; set; }

        public CCard(int id, int number, int cvv, DateTime date) : base(id)
        {
            this.Number = number;
            this.CVV = cvv;
            this.Date = date;
        }

        public void PrintCCardData()
        {
            Console.WriteLine("This is the Credit Card number: " + Number + " This is the secret code: " + CVV + " Payment was made on this date: " + Date);
        }
    }
}