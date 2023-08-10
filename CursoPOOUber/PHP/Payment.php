<?php

//Definition of the "Payment" class.
class Payment {

    //Attributes
    public $id;

    public function __construct($id){
        $this->id = $id;
    }

    public function printPaymentData() {
        echo "This is the Id of this payment: " + $this->id;
    }       
}
?>