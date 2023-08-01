package CursoPOOUber.Java;

//Software UberAapp
public class Main {
    public static void main(String[] args) {
        // System.out.println("Hello World");
    
        System.out.println("Starting Process...");

        System.out.println("Customer requesting a car...");
        Car car = new Car("LicDemo01", new Account("Joan Alexander", "DocDemo01"));
        car.passengers = 4;
        car.printDataCar();

        System.out.println("Requesting an UberX");

        System.out.println("UberX requested...");
        UberX uberX = new UberX("LicDemo02", new Account("Nathaly Diaz", "DocDemo02"), "Hyundai", "I10");
        uberX.passengers = 4;
        uberX.printDataCar();
        uberX.printUberxData();
    }
}
