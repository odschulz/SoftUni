<?php

namespace Classes;


class Guest {
    private $firstName;
    private $lastName;
    private $id;

    public function __construct($firstName, $lastName, $id){
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setId($id);
    }

    public function setFirstName($firstName){
        if (empty($firstName)) {
            throw new \InvalidArgumentException("First name cannot be empty.");
        }

        $this->firstName = $firstName;
    }

    public function getFirstName(){
        return $this->firstName;
    }

    public function setLastName($lastName){
        if (empty($lastName)) {
            throw new \InvalidArgumentException("Last name cannot be empty.");
        }

        $this->lastName = $lastName;
    }

    public function getLastName(){
        return $this->lastName;
    }

    public function getFullName() {
        return $this->getFirstName() . ' ' . $this->getLastName();
    }

    public function setId($id){
        if (empty($id)) {
            throw new \InvalidArgumentException("ID cannot be empty.");
        }

        $this->id = $id;
    }

    public function getId(){
        return $this->id;
    }

    public function __toString() {
        return $this->getFullName();
    }
}