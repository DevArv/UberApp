//Definition of the child class "Driver", which inherits from the class "Car".

class Driver extends Account {
    constructor(name, document){
        super(name, document)
        this.driver.name = name;

    }

    printDataDriver() {
        console.log(this.name)
        console.log(this.document)
        console.log(this.email)
        console.log(this.password)
    }
}