<?php
require_once("car.php");
require_once("Account.php");
require_once("User.php");
require_once("Driver.php");
require_once("UberX.php");
require_once("index.php");

echo "Starting Process...";

echo "Customer requesting a car...";
$car = new $Car("LicDemo01", new Account("Joan Alexander", "DocDemo01"));
$car->passsenger = 4;
$car->printDataCar();

echo "Requesting an UberX";
$UberX = new $uberX("LicDemo02", new Account("Nathaly Diaz", "DocDemo02"), "Hyundai", "I10");
$UberX->passsenger = 4;
$UberX->printDataCar();
$UberX->printUberxData();
?>