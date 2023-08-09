//Definition of the "Cash" class, which inherits from "Payment" class.
class Cash extends Payment {

    constructor(id) {
        super(id)
        this.id = id;
    }

    printCashData() {
        console.log("This user has paid in cash.");
    }
}