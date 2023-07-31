package CursoPOOUber.Java;


class User extends Account {
    public User(String name, String document, String email, String password){
        super(name, document, email, password);
    }

    void printDataUser(){
        System.out.println("User Name: " + name + " User Document: " + document + " User Email: " + email + " User Password: " + password);
    }
}
