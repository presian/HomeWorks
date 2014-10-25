<?php


class Apartment extends Room {
    const APARTMENT_BED_COUNT = 4;

    function __construct($price, $roomNumber)
    {
        parent::__construct(Apartment::APARTMENT_BED_COUNT,true,true,$price,$roomNumber,RoomType::DIAMOND);
        $this->addExtras(Extras::TV);
        $this->addExtras(Extras::AC);
        $this->addExtras(Extras::REFRIGERATOR);
        $this->addExtras(Extras::KITCHEN_BOX);
        $this->addExtras(Extras::MINI_BAR);
        $this->addExtras(Extras::BATHTUB);
    }


} 