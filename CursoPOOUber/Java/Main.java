package CursoPOOUber.Java;

//Segun los metodos constructores para Car y Account, hemos indicado cuales informaciones son obligatorias, es por esto que
//aqui pasamos sus valores directamente.
//El primer valor es la licencia
//El segundo valor es el nombre el conductor(con esto estamos instanciando directamente su nombre y quien es el conductor,
//ya que estan relacionados en nuestro metodo contructor de Car).
//El tercer valor es su documento de identificacion.

public class Main {
    public static void main(String[] args) {
        // System.out.println("Hello World");
    
        System.out.println("Empezando proceso...");

        System.out.println("Car...");
        Car car = new Car("LicDemo01", new Account("Joan Alexander", "DocDemo01"));
        car.passengers = 4;
        car.printDataCar();

        System.out.println("Solicitando UberX");

        // pendiente crear print para UberX
    }
}
