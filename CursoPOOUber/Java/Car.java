package CursoPOOUber.Java;

//Definition of the "Car" class
public class Car {
    Integer id;
    public String license;
    public Account driver;
    public Integer passengers;

    //With the constructor method we are indicating to the program which parameters are mandatory to create a method.
    //The use of Account driver, is to instantiate that a driver must have an account.
    //The use of "this" is to differentiate and to indicate that the first one is a variable.

    public Car(String license, Account driver){
        this.license = license;
        this.driver = driver;

    }
    
    //With the constructor method we are indicating to the program which parameters are mandatory to create an "Account" type method.

    void printDataCar() {
        System.out.println("License: " + license + " Driver's name: " + driver.name + " Passengers: " + passengers);
    }
}
