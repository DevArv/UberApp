<?php
require_once('account.php');

class Driver extends Account {

    public function __construct($name, $document) {
        $this->name = $name;
        $this->document = $document;
    }

    public function printDataDriver() {
        echo "Name: " + $this->name + " Document: " + $this->document + " E-mail: " + $this->email + " Password: " + $this->password;
    }
}
?>