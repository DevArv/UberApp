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
    private int Passengers { get; set;}

    public Car(string license, Account driver)
    {
        this.License = license;
        this.Driver = driver;
    }

    //With the constructor method we are indicating to the program which parameters are mandatory to create an "Account" type method.
    public virtual void PrintDataCar()
    {
        if(Passengers != 0)
        {
            Console.WriteLine("These are the details of this car: " + " License: " + License + " Driver's Name: " + Driver.Name + " Passengers: " + Passengers);
        }
    }

    public int GetPassengers()
    {
        return Passengers;
    }

    public virtual void SetPassengers(int passengers)
    {
        if  (passengers == 4)
        {
            Passengers = passengers;
        }
        else{
            Console.WriteLine("This type of Uber is only for 4 passengers.");
        }
    }

    public int GetId() 
    {
        return Id;
    }

    public void SetId(int id) 
    {
        Id = id;
    }

    public string GetLicense() 
    {
        return License;
    }

    public void SetLicense(string license) 
    {
        License = license;
    }

    public Account GetDriver() 
    {
        return Driver;
    }

    public void SetDriver(Account driver) {
        Driver = driver;
    }

    }
}