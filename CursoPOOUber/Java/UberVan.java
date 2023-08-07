package CursoPOOUber.Java;
import java.util.ArrayList;
import java.util.Map;

//El primer Map representa la marca del UberBlack
//El segundo Map representa el modelo y el año del vehiculo
class UberVan extends Car {
    Map<String, Map<String,Integer>> typeCarAccepted;

    //Material de los asientos.
    ArrayList<String> seatsMaterial;

    public UberVan(String license, Account driver,
    Map<String, Map<String,Integer>> typeCarAccepted,
    ArrayList<String> seatsMaterial){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatsMaterial = seatsMaterial;
    }

    void printUberVanData() {
        System.out.println("Type Car Accepted: " + typeCarAccepted + " Seats Material: " + seatsMaterial);
    }
}
