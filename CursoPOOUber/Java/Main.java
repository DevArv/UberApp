package CursoPOOUber.Java;

import java.time.LocalDate;

//Software UberAapp
public class Main {
    public static void main(String[] args) {
        // System.out.println("Hello World");
    
        System.out.println("Starting Process...");

        System.out.println("Customer requesting a car...");
        Car car = new Car("LicDemo01", new Account("Joan Alexander", "DocDemo01"));
        car.setPassengers(4);
        car.printDataCar();

        System.out.println("Requesting an UberX");

        System.out.println("UberX requested...");
        UberX uberX = new UberX("LicDemo02", new Account("Nathaly Diaz", "DocDemo02"), "Hyundai", "I10");
        uberX.getPassengers();
        uberX.printDataCar();
 
        // System.out.println("Requesting an UberVan");

        // System.out.println("UberVan requested...");
        // UberVan uberVan = new UberVan("LicDemo02", new Account("Nathaly Diaz", "DocDemo02"));
        // uberVan.printDataCar();
        // uberVan.getPassengers();

        System.out.println("Method of payment...");

        System.out.println("This user is paying with a credit card...");
        CCard ccard = new CCard(01, 1098765432, 321, LocalDate.now());
        ccard.printCCardData();
    }
}
