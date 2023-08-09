//Definition of the "Paypall" class, which inherits from "Payment" class.
class Paypall extends Payment {

    constructor(id, email) {
        super(id)
        this.email = email;        
    }

    printPaypallData() {
        console.log(this.email);
    }
}