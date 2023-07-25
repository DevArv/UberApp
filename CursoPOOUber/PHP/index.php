<?php
require_once("car.php");
require_once("uberX.php");
require_once("uberPool.php");
require_once("index.php");

$uberX = new UberX("LIC01", new Account("Joan Alexander", "DOC01"), 
"Mazda", "CX7");
$uberX-> printDataCar();
?>