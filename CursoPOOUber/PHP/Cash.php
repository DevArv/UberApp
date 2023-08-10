<?php
require_once('Payment.php');
//Definition of the "Cash" class, which inherits from "Payment" class.
class Cash extends Payment {
    
    public function __construct($id){
        parent::__construct($id);
        $this->id = $id;
    }

    public function printCashData() {
        echo "This user has paid in cash.";
    }
}
?>