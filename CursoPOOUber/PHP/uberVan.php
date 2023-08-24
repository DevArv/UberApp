<?
require_once("car.php");
class UberVan extends Car {
    public $typeCarAccepted;
    public $seatsMaterial;
    protected $passenger;

    public function __construct($license, $driver, 
    $typeCarAccepted, $seatsMaterial){
        parent::__construct($license,$driver);
        $this->typeCarAccepted = $typeCarAccepted;
        $this->seatsMaterial = $seatsMaterial;
    }

    public function printDataCar() {
        echo " Type Car Accepted: " + $this->typeCarAccepted + " Seats Material: " + $this->seatsMaterial;
    }

    public function setPassenger($passenger) {
        if ($passenger == 6) {
            $this->passenger = $passenger;
        } else {
            echo "This type of Uber is only for 6 passengers.";
        }
    }
}
?>