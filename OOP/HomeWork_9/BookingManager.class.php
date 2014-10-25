<?php


class BookingManager {
    static function bookRoom(Room $room, Reservation $reservation){
        try{
            $room->addReseravtion($reservation);
            echo "\nRoom " . '<strong>' . $room->getRoomNumber() . '</strong> successfully booked for <strong>'
                . $reservation->getGuest()->getFirstName() .' '. $reservation->getGuest()->getLastName()
                . '</strong> from <time>'
                . date("d-m-Y",$reservation->getStartDate())
                . '</time> to <time>'
                . date("d-m-Y",$reservation->getEndDate())
                . '</time>!';
        }
        catch (EReservationException $e){
            echo($e->getMessage());
        }
    }
} 