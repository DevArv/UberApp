using System;

namespace AccountNS
{
    public class Account
    {
 
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Document { get; set; }
        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public void PrintDataAccount()
        {
            Console.WriteLine("Estos son los datos de esta cuenta: " + "Id: " + Id + " Nombre: " + Name + " Documento: " + Document + " Correo: " + Email + " Contraseña: " + Password);
        }

        public static implicit operator Account(string v)
        {
            throw new NotImplementedException();
        }
    }

}