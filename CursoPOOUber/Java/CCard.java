package CursoPOOUber.Java;
import java.time.LocalDate;

//Definition of the "CCard" class, which inherits from "Payment" class.
class CCard extends Payment{

    //Attributes
    Integer number;
    Integer cvv;
    LocalDate date;

    public CCard(Integer id, Integer number, Integer cvv, LocalDate date) {
        super(id);
        this.number = number;
        this.cvv = cvv;
        this.date = date;
    }

    void printCCardData() {
        System.out.println("This is the Credit Card number: " + number + " This is the secret code: " + cvv + " Payment was made on this date: " + date);
    }
}
