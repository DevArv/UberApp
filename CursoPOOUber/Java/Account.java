package CursoPOOUber.Java;

//Definition of the "Account" class.
public class Account {
    Integer id;
    public String name;
    public String document;
    public String email;
    public String password;

    public Account(String name, String document) {
    this.name = name;
    this.document = document;
    }

    void printDataDriver(){
        System.out.println("Name: " + name + " Document: " + document + " E-mail: " + email + " Password: " + password);
    }
}
