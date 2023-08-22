class UberBlack extends Car {
    constructor(license, driver, typeCarAccepted, seatMaterial) {
        super(license, driver)
        this.typeCarAccepted = typeCarAccepted;
        this.seatMaterial = seatMaterial;
    }

    setPassengers(passengers) {
        if (passengers === 4) {
            this.passengers = passengers;
        } else {
            console.log("This type of Uber is only for 4 passengers.");
        }
    }

    printDataCar() {
        super.printDataCar();
        console.log("License: " + this.license + " Driver: " + this.driver.name);
    }
}