var car = new Car("LicDemo01", new Account("Joan Alexander", "DocDemo01"))
car.passenger = 4;
car.printDataCar();

var uberX = new UberX("LicDemo02", new Account("Nathaly Diaz", "DocDemo02"), "Hyundai", "I10")
uberX.passenger = 4;
uberX.printDataCar();
uberX.printUberxData();

var ccard = new CCard('01', '0987654321', '321', new Date())
ccard.printCCardData();