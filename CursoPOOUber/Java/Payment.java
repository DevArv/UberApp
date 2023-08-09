package CursoPOOUber.Java;

//Definition of the "Payment" class.
public class Payment {
    Integer id;

    //Attributes
    public Payment(Integer id) {
        this.id = id;
    }

    void printPaymentData() {
        System.out.println("This is the ID of this payment: " + id);
    }
}
