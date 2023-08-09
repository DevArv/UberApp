package CursoPOOUber.Java;

//Definition of the "Paypall" class, which inherits from "Payment" class.
class Paypall extends Payment {

    //Attributes
    String email;

    public Paypall(Integer id, String email) {
        super(id);
        this.email = email;
    }

    void printPaypallData() {
        System.out.println("This is the email of the paypall account of this user: " + email);
    }
    
}
