<?php

namespace InterfacesAndExceptions;
use Exception;

class EReservationException extends Exception {
    public function __construct($message = "Reservation already exist") {
        parent::__construct($message);
    }
}