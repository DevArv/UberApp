package CursoPOOUber.Java;

//Definition of the "UberX" class, which inherits form the "Car" class.
class UberX extends Car {

    //Attributes
    String brand;
    String model;
    
    public UberX(String license, Account driver, String brand, String model){
        super(license, driver);
        this.brand = brand;
        this.model = model;
        setPassengers(4);
    }

    void printUberxData(){
        System.out.println("Car Brand: " + brand + " UberX Model: " + model);
    }
}
