package CursoPOOUber.Java;

//Definition of the "UberPool" class, which inherits from "Car" class.
class UberPool extends Car {

    //Attributes
    String brand;
    String model;

    public UberPool(String license, Account driver, String brand, String model){
        super(license, driver);
        this.brand = brand;
        this.model = model;
        setPassengers(4);
    }

    @Override
    void printDataCar(){
        super.printDataCar();
        System.out.println("Car Brand: " + brand + " UberPool model: " + model);
    }
}
