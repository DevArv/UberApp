package CursoPOOUber.Java;

//Definition of the child class "Driver", which inherits from the class "Car".
public class Driver extends Account{
    
    public Driver(String name, String document){
        super(name, document);
    }

    @Override
    void printDataDriver(){
        System.out.println("Name: " + name + " Document: " + document + " E-mail: " + email + " Password: " + password);
    }
}
