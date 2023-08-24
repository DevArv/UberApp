<?php
require_once('Car.php');
class UberX extends Car {
    public $brand;
    public $model;


    public function __construct($license, $driver, $brand, $model){
        parent::__construct($license,$driver);
        $this->brand = $brand;
        $this->model = $model;
    }

    public function setPassenger($passenger) {
        if ($passenger == 4) {
            $this->passenger = $passenger;
        } else {
            echo "This type of Uber is only for 4 passengers.";
        }
    }
    
    public function printDataCar() {
        echo "Car brand: $this->brand; <br>
                UberX model: {$this->model} <br>";
    }
}
?>