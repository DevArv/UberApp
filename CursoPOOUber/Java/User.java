package CursoPOOUber.Java;

//Definition of the child class "User", which inherits from the class "Car".
public class User extends Account {

    private Integer id;

    public User(String name, String document){
        super(name, document);
    }

    void printDataUser(){
        System.out.println("User ID: " + id + " Name: " + name + " Document: " + document);
    }
}
