//With these changes we are creating the constructor method we are indicating which of these properties are mandatory.
//Definition of the "Car" class

class Car{

    constructor(license, driver) {
        this.id;
        this.license = license;
        this.driver = driver;
        this.passenger;
    }

    printDataCar() {
        console.log(this.license)
        console.log(this.driver.name)
        console.log(this.passenger)
    }
}