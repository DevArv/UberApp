<?php
require_once('account.php');

class User extends Account {
    public $id;

    public function __construct($name, $document) {
        $this->name = $name;
        $this->document = $document;
    }

    public function printDataUser() {
        echo "User ID: " + $this->id + " Name: " + $this->name + " Document: " + $this->document;
    }
}
?>