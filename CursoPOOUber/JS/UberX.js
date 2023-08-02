//Definition of the "UberX" class, which inherits form the class "Car".

class UberX extends Car {
    constructor(license, driver, brand, model) {
        super(license, driver)
        this.brand = brand;
        this.model = model;
    }

    printUberxData() {
        console.log(this.brand)
        console.log(this.model)
    }
}