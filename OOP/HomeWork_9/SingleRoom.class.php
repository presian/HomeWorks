<?php


class SingleRoom extends Room{
    const SINGLE_ROOM_BED_COUNT = 1;

    function __construct($price, $roomNumber)
    {
        parent::__construct(SingleRoom::SINGLE_ROOM_BED_COUNT,false,true,$price,$roomNumber,RoomType::STANDART);
        $this->addExtras(Extras::TV);
        $this->addExtras(Extras::AC);
    }


} 