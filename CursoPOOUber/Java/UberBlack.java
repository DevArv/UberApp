package CursoPOOUber.Java;
import java.util.ArrayList;
import java.util.Map;

//The first Map represents the brand of the UberBlack
//The second Map represents the model.
class UberBlack extends Car {
    Map<String, Map<String,Integer>> typeCarAccepted;

    //Car seats material.
    ArrayList<String> seatsMaterial;

    public UberBlack(String license, Account driver,
    Map<String, Map<String,Integer>> typeCarAccepted,
    ArrayList<String> seatsMaterial){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }

    void printUberBlackData() {
        System.out.println("Type Car Accepted: " + typeCarAccepted + " Seats Material: " + seatsMaterial);
    }
}
