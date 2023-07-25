package CursoPOOUber.Java;

class Car {
    Integer id;
    String license;
    Account driver;
    Integer passengers;

    //Con el metodo constructor le estamos diciendo al programa cuales parametros son obligarotios para crear un metodo
    //tipo Car.
    //El uso de Account driver, es para instanciar de que un conductor debe de tener una cuenta.
    //El uso de this es para diferenciar e indicar de que la primera es una variable.

    public Car(String license, Account driver){
        this.license = license;
        this.driver = driver;

    }
    
    //Con el metodo constructor le estamos diciendo al programa cuales parametros son obligatorios para crear un metodo 
    //tipo Account.

    void printDataCar() {
        System.out.println("License: " + license + " Driver's name: " + driver.name);
    }
}
