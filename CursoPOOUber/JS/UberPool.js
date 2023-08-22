class UberPool extends Car {
    constructor(license, driver, brand, model) {
        super(license, driver)
        this.brand = brand;
        this.model = model;
        this.setPassengers(4);
    }

    printDataCar() {
        super.printDataCar();
        console.log("Car Brand: " + brand + " UberPool model: " + model);
    }
}