<?php


class EReservationException extends Exception {

    function __construct()
    {
        parent::__construct("The room is not available in this time.");
    }
}