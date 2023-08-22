//With these changes we are creating the constructor method we are indicating which of these properties are mandatory.
//Definition of the "Car" class

class Car{

    constructor(license, driver) {
        this.license = license;
        this.driver = driver;
    }

    printDataCar() {
        if(this.passengers != null) {
            console.log("license: " + this.license + " Driver's name: " + this.driver.name + " Passengers: " + this.passengers)
        }
    }

    get passengers() {
        return this._passengers;
    }

    set passengers(passengers) {
        if (passengers === 4) {
            this.license = passengers;
        } else {
            console.log("This type of Uber is only for 4 passengers");
        }
    }

    get id() {
        return this._id;
    }

    set id(id) {
        this._id = id;
    }

    get license() {
        return this._license;
    }

    set license(license) {
        this._license = license;
    }

    get driver() {
        return this._driver;
    }

    set driver(driver) {
        this._driver = driver;
    }
}