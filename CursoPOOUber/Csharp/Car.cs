using System;
using System.Collections;
using AccountNS;

namespace CarNS
{
    public class Car
    {
    public int Id { get; set;}
    public string License { get; set;} = "";
    public Account Driver { get; set;} = "";   
    public int Passengers { get; set;}

    public Car(string License, Account Driver)
    {
        this.License = License;
        this.Driver = Driver;
    }

    // public void PrintDataCar()
    // {
    //     Console.WriteLine("Estos son los datos de este carro: " + "Id: " + Id + " Licencia: " + License + " Driver: " + Driver + " Pasajeros: " + Passengers);
    // }

    }
}