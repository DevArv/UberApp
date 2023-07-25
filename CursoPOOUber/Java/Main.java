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

        Car car = new Car("LICDEMO01", new Account("Joan Alexander", "DOCDEMO01"));
        car.passengers = 4;
        car.printDataCar();

        Car car2 = new Car("LICDEMO02", new Account("Nathaly Diaz", "DOCDEMO02"));
        car2.passengers = 5;
        car2.printDataCar();
    }
}
