<?php


class Reservation {
    private $startDate;
    private $endDate;
    private $guest;

    function __construct($endDate, $startDate, Guest $guest)
    {
        $this->endDate = $endDate;
        $this->guest = $guest;
        $this->startDate = $startDate;
    }

    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }

    public function getEndDate()
    {
        return $this->endDate;
    }

    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    public function getStartDate()
    {
        return $this->startDate;
    }

    public function setGuest($guest)
    {
        $this->guest = $guest;
    }

    public function getGuest()
    {
        return $this->guest;
    }

    function __toString()
    {
        $output = $this->getGuest()
            . "\nStart date: "
            . date("d-m-Y", strtotime($this->getStartDate()))
            . "End date: "
            . date("d-m-Y", strtotime($this->getEndDate()));
        return $output;
    }


} 