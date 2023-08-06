using System;

namespace AccountNS
{

    //definition of the "Account" class.
    public class Account
    {
        //Attributes
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Document { get; set; }
        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public Account(string name, int document) 
        {
            this.Name = name;
            this.Document = document;

        }
        
        public virtual void PrintDataDriver()
        {
            Console.WriteLine("These are the deatils of this account: " + "Name: " + Name + " Document: " + Document + " E-mail: " + Email + " Password: " + Password);
        }

        public static implicit operator Account(string v)
        {
            throw new NotImplementedException();
        }
    }

}