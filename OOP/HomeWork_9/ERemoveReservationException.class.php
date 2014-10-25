<?php


class ERemoveReservationException extends Exception{
    function __construct()
    {
        parent::__construct("This reservation is not exist!");
    }
}