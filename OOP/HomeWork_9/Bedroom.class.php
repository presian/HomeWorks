<?php


class Bedroom extends Room {
    const BEDROOM_BED_COUNT = 2;

    function __construct($price, $roomNumber)
    {
        parent::__construct(Bedroom::BEDROOM_BED_COUNT,true,true,$price,$roomNumber,RoomType::GOLD);
        $this->addExtras(Extras::TV);
        $this->addExtras(Extras::AC);
        $this->addExtras(Extras::REFRIGERATOR);
        $this->addExtras(Extras::MINI_BAR);
        $this->addExtras(Extras::BATHTUB);
    }


} 