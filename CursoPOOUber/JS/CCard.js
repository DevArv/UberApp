//Definition of the "Paypall" class, which inherits from "Payment" class.
class CCard extends Payment {

    constructor(id, number, cvv, date) {
        super(id)
        this.number = number;
        this.cvv = cvv;
        this.date = date;
    }

    printCCardData() {
        console.log(this.number);
        console.log(this.cvv);
        console.log(this.date);
    }
}