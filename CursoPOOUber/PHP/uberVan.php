<?
require_once("car.php");
class UberVan extends Car {
    public $typeCarAccepted;
    public $seatsMaterial;

    public function __construct($license, $driver, 
    $typeCarAccepted, $seatsMaterial){
        parent::__construct($license,$driver);
        $this->typeCarAccepted = $typeCarAccepted;
        $this->seatsMaterial = $seatsMaterial;
    }

    public function printUberVanData() {
        echo " Type Car Accepted: " + $this->typeCarAccepted + " Seats Material: " + $this->seatsMaterial;
    }
}
?>