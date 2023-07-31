using AccountNS;

namespace DriverDetails
{
    public class Driver : Account
    {
        public Driver(string name, int document, string email, string password)
        {
            this.Name = name;
            this.Document = document;
            this.Email = email;
            this.Password = password;
        }

        public void PrintDriverData()
        {
            Console.WriteLine("User Name: " + Name, " User Document: ", Document, " User Email: " + Email, " User Password: " + Password);
        }
    }
}