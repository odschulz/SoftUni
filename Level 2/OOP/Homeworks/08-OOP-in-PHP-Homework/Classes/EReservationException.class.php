<?php

namespace Classes;


class EReservationException extends \Exception {
    public function __construct() {
        parent::__construct("The room is booked for this period.", 101);
    }
}