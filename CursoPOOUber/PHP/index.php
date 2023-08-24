<?php
require_once('car.php');
require_once('Account.php');
require_once('User.php');
require_once('Driver.php');
require_once('UberX.php');
require_once('index.php');
require_once('Payment.php');
require_once('CCard.php');
require_once('UberVan.php');

echo "Starting Process...";

echo "Customer requesting a car...";
$car = new $Car("LicDemo01", new Account("Joan Alexander", "DocDemo01"));
$car->passsenger = 4;
$car->printDataCar();

echo "Requesting an UberX";
$uberX = new $UberX("LicDemo02", new Account("Nathaly Diaz", "DocDemo02"), "Hyundai", "I10");
$uberX->passsenger = 4;
$uberX->printDataCar();

echo "Method of payment...";

echo "This user is paying with a credit card...";
$cCard = new $CCard(01, 0987654321, 321, date('2023-08-10'));
$cCard->printCCardData();

$uberVan = new $UberVan("LICDEMO_VAN", new Account("Ana Lucia", "DOCDEMO_VAN"), "Suzuki", "DM01");
$uberVan->setPassenger(6);
$uberVan->printDataCar();
?>