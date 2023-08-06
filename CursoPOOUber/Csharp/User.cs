using AccountNS;

namespace UserDetails
{
    //Definition of the child "User" class, which inherits from "Account" class.
    public class User : Account
    {
        public User(string name, int document) : base(name, document)
        {

        }
        void PrintDataUser() {
            Console.WriteLine("User ID: " + Id + " Name: " + Name + " Document: " + Document);
        }

    }
}