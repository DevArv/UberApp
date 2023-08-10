<?php
require_once('Payment.php');
//Definition of the "Paypall" class, which inherits from "Payment" class.
class Paypall extends Payment {

    //Attributes
    public $email;

    public function __construct($id, $email){
        parent::__construct($id);
        $this->email = $email;
    }

    public function printPaypallData(){
        echo "This is the email of the paypall account of this user: " + $this->email;
    }
}
?>