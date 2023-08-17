package CursoPOOUber.Java;

//Definition of the "Car" class
public class Car {
    private Integer id;
    String license;
    Account driver;
    private Integer passengers;

    //With the constructor method we are indicating to the program which parameters are mandatory to create a method.
    //The use of Account driver, is to instantiate that a driver must have an account.
    //The use of "this" is to differentiate and to indicate that the first one is a variable.

    public Car(String license, Account driver){
        this.license = license;
        this.driver = driver;

    }
    
    //With the constructor method we are indicating to the program which parameters are mandatory to create an "Account" type method.

    void printDataCar() {
        if(passengers != null){
            System.out.println("License: " + license + " Driver's name: " + driver.name + " Passengers: " + passengers);
        }
    }

    //With set and get, we establish the rule of what is the mandatory number of passengers for each type of Uber.

    public Integer getPassengers(){
        return passengers;
    }

    public void setPassengers(Integer passengers){
        if(passengers == 4){
            this.passengers = passengers;
        }else{
            System.out.println("This type of Uber is only for 4 passengers.");
        }
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getLicense() {
        return license;
    }

    public void setLicense(String license) {
        this.license = license;
    }

    public Account getDriver() {
        return driver;
    }

    public void setDriver(Account driver) {
        this.driver = driver;
    }

    
}
