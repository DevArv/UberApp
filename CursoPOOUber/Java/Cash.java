package CursoPOOUber.Java;

//DEfinition of the "Cash" class, which inherits from "Payment" class.
class Cash extends Payment {
    
    public Cash(Integer id){
        super(id);
        this.id = id;
    }

    void printCashData() {
        System.out.println("This user has paid in cash.");
    }
}
