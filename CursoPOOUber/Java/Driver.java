package CursoPOOUber.Java;

class Driver extends Account{
    public Driver(String name, String document, String email, String password){
        super(name, document, email, password);
    }

    void printDataDriver(){
        System.out.println("User Name: " + name + " User Document: " + document + " User Email: " + email + " User Password: " + password);
    }
}
