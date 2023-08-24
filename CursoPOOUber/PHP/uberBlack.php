<?
require_once("car.php");
class UberBlack extends Car {
    public $typeCarAccepted;
    public $seatsMaterial;

    public function __construct($license, $driver, 
    $typeCarAccepted, $seatsMaterial){
        parent::__construct($license,$driver);
        $this->typeCarAccepted = $typeCarAccepted;
        $this->seatsMaterial = $seatsMaterial;
    }

    public function setPassenger($passenger) {
        if ($passenger == 4) {
            $this->passenger = $passenger;
        } else {
            echo "This type of Uber is only for 4 passengers.";
        }
    }

    public function printDataCar() {
        echo "Type Car Accepted: $this->typeCarAccepted <br>
                Seats Material: {$this->seatsMaterial} <br>";
    }
}
?>