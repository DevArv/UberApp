<?php
//Definition of the "Account" class.
class Account {
    public $id;
    public $name;
    public $document;
    public $email;
    public $password;

    public function __construct($name, $document) {
        $this->name = $name;
        $this->document = $document;
    }

    public function printDataDriver() {
        echo "Name: " + $this->name + " Document: " + $this->document + " E-mail: " + $this->email + " Password: " + $this->password;
    }
}
?>