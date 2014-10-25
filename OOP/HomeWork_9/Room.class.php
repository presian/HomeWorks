<?php
abstract class Room implements iReservable
{
    protected $reservations = [];
    protected $roomType;
    protected $hasRestroom;
    protected $hasBalcony;
    protected $bedCount;
    protected $roomNumber;
    protected $extras = [];
    protected $price;

    function __construct($bedCount, $hasBalcony, $hasRestroom, $price, $roomNumber, $roomType)
    {
        $this->bedCount = $bedCount;
        $this->hasBalcony = $hasBalcony;
        $this->hasRestroom = $hasRestroom;
        $this->price = $price;
        $this->roomNumber = $roomNumber;
        $this->roomType = $roomType;
    }

    public function setBedCount($bedCount)
    {
        $this->bedCount = $bedCount;
    }

    public function setExtras($extras)
    {
        $this->extras = $extras;
    }

    public function setHasBalcony($hasBalcony)
    {
        $this->hasBalcony = $hasBalcony;
    }

    public function setHasRestroom($hasRestroom)
    {
        $this->hasRestroom = $hasRestroom;
    }

    public function setPrice($price)
    {
        $this->price = $price;
    }

    public function setRoomNumber($roomNumber)
    {
        $this->roomNumber = $roomNumber;
    }

    public function getBedCount()
    {
        return $this->bedCount;
    }

    public function getExtras()
    {
        return $this->extras;
    }

    public function getHasBalcony()
    {
        return $this->hasBalcony;
    }

    public function getHasRestroom()
    {
        return $this->hasRestroom;
    }

    public function getPrice()
    {
        return $this->price;
    }

    public function getReservations()
    {
        return $this->reservations;
    }

    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    public function getRoomType()
    {
        return $this->roomType;
    }

    public function setRoomType($roomType)
    {
        $this->roomType = $roomType;
    }

    // Methods
    function  addReseravtion($reservation)
    {
        if(!$this->isValidReservation($reservation)&&count($this->reservations)>0){
            throw new EReservationException;
        }
        else{
            $this->reservations[] = $reservation;
        }

    }

    function removeReservation($reservation)
    {
        if (in_array($reservation, $this->reservations)) {
            $index = array_search($reservation, $this->reservations);
            unset($this->reservations[$index]);
            $this->reservations = array_values($this->reservations);
        } else {
            throw new ERemoveReservationException;
        }

    }

    public function addExtras($extras)
    {
        $this->extras[] = $extras;
    }

    public function __toString()
    {
        $output = "Room type: " . (get_class($this))
            . "\nRoom #: $this->roomNumber\nRoom class: $this->roomType"
            . "\nNumber of beds: $this->bedCount"
            . "\nBalcony:" . ($this->hasBalcony ? " Yes" : " No")
            . "\nRestroom:" . ($this->hasRestroom ? " Yes" : " No")
            . "\nExtras: " . implode(", ", $this->extras)
            . "\nPrice: $this->price";
        return $output;
    }


    function isValidReservation(Reservation $reservation)
    {
        foreach ($this->reservations as $existingReservation) {
            if (($reservation->getStartDate() >=  $existingReservation->getStartDate()  &&
                $reservation->getStartDate() <=  $existingReservation->getEndDate())
            ) {
                throw new EReservationException($this->roomNumber, $reservation);
            } elseif (($reservation->getEndDate() >=  $existingReservation->getStartDate()  &&
                $reservation->getEndDate()  <=   $existingReservation->getEndDate())
            ) {
                throw new EReservationException($this->roomNumber, $reservation);
            }
        }
    }

} 