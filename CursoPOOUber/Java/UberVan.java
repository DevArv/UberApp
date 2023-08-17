package CursoPOOUber.Java;
import java.util.ArrayList;
import java.util.Map;

//The first Map represents the brand of UberVan
//The second Map represents the model and year of the vehicle.
class UberVan extends Car {
    Map<String, Map<String,Integer>> typeCarAccepted;

    //Seat material.
    ArrayList<String> seatsMaterial;
    private Integer passengers;


    public UberVan(String license, Account driver){
        super(license, driver);
    }

    public UberVan(String license, Account driver,
    Map<String, Map<String,Integer>> typeCarAccepted,
    ArrayList<String> seatsMaterial){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }

    @Override
    public void setPassengers(Integer passengers){
        if(passengers == 6){
            this.passengers = passengers;
        }else{
            System.out.println("This type of Uber is only for 6 passengers.");
        }
    }

    @Override
    void printDataCar(){
        super.printDataCar();
        System.out.println("License: " + license + " Driver: " + driver.name);
    }


}
