<?php


class Guest {
    private $firstName;
    private $lastName;
    private $id;

    function __construct($firstName, $lastName, $id)
    {
        $this->firstName = $firstName;
        $this->id = $id;
        $this->lastName = $lastName;
    }

    public function setFirstName($firstName)
    {
        $this->firstName = $firstName;
    }

    public function getFirstName()
    {
        return $this->firstName;
    }

    public function setId($id)
    {
        $this->id = $id;
    }

    public function getId()
    {
        return $this->id;
    }

    public function setLastName($lastName)
    {
        $this->lastName = $lastName;
    }

    public function getLastName()
    {
        return $this->lastName;
    }

    function __toString()
    {
        $output = "Guest {Name: $this->firstName $this->lastName, ID: $this->id}";
        return $output;
    }
} 