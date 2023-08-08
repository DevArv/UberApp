using System;
using System.Collections;
using AccountNS;

namespace CarNS
{
    //Definition of "Car" class.
    public class Car
    {

    //Attributes    
    public int Id { get; set;}
    public string License { get; set;} = "";
    public Account Driver { get; set;}
    public int Passengers { get; set;}

    public Car(string license, Account driver)
    {
        this.License = license;
        this.Driver = driver;
    }

    public void PrintDataCar()
    {
        Console.WriteLine("These are the details of this car: " + " License: " + License + " Driver's Name: " + Driver.Name + " Passengers: " + Passengers);
    }

    public void PrintCustomerData() 
    {
        Console.WriteLine("These are the details of the customer: " + License + " Customer's Name: " + Driver.Name);
    }

    }
}