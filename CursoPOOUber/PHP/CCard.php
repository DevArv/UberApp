<?php
require_once('Payment.php');

//Definition of the "CCard" class, which inherits from "Payment" class.
class CCard extends Payment {

    //Attributes
    public $number;
    public $cvv;
    private $date;

    public function __construct($id, $number, $cvv, $date){
        parent::__construct($id);
        $this->number = $number;
        $this->cvv = $cvv;
        $this->date = new DateTime($date);
    }

    public function printCCardData() {
        echo "This is the Credit Card number: " + $this->number + " This is the secret cpde: " + $this->cvv + " Payment was made on this date: " + $this->date->format('2023-08-10');
    } 
}
?>