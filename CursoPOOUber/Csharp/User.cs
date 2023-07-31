using AccountNS;

namespace UserDetails
{
    public class User : Account
    {
        public User(string name, int document, string email, string password)
        {
            this.Name = name;
            this.Document = document;
            this.Email = email;
            this.Password = password;
        }

        public void PrintUserData()
        {
            Console.WriteLine("User Name: " + Name, " User Document: ", Document, " User Email: " + Email, " User Password: " + Password);
        }
    }
}