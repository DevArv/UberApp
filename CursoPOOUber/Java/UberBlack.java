package CursoPOOUber.Java;
import java.util.ArrayList;
import java.util.Map;

//The first Map represents the brand of the UberBlack
//The second Map represents the model.
class UberBlack extends Car {
    Map<String, Map<String,Integer>> typeCarAccepted;

    //Car seats material.
    ArrayList<String> seatsMaterial;
    private Integer passengers;

    public UberBlack(String license, Account driver){
        super(license, driver);
    }

    public UberBlack(String license, Account driver,
    Map<String, Map<String,Integer>> typeCarAccepted,
    ArrayList<String> seatsMaterial){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }

    @Override
    public void setPassengers(Integer passenger){
        if(passenger == 4){
            this.passengers = passenger;
        }else{
            System.out.println("This type of Uber is only for 4 passengers.");
        }
    }

    @Override
    void printDataCar(){
        super.printDataCar();
        System.out.println("License: " + license + " Driver: " + driver.name);
    }
}
