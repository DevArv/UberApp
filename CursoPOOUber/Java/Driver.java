package CursoPOOUber.Java;

class Driver extends Account{
    public Driver(String name, String document){
        super(name, document);
    }

    void printDataDriver(){
        System.out.println("User Name: " + name + " User Document: " + document + " User Email: " + email + " User Password: " + password);
    }
}
