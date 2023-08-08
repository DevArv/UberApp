using PaymentTypes;

namespace PaymentTypes.Cash 
{

    //Definition of the "Cash" class, which inherits from "Cash" class.
    public class Cash : Payment
    {

        public Cash(int id) : base(id)
        {
            this.Id = id;
        }

        public void PrintCashData()
        {
            Console.WriteLine("This user has paid in cash.");
        }
        
    }
}