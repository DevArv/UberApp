package CursoPOOUber.Java;

class UberX extends Car {
    String brand;
    String model;
    
    public UberX(String license, Account driver, String brand, String model){
        super(license, driver);
        this.brand = brand;
        this.model = model;
    }

    void printUberxData(){
        System.out.println("UberX License" + license + " UberX Driver: " + driver + " UberX Brand: " + brand + " UberX Model: " + model);
    }
}
