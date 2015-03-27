<?php

namespace Classes;


class SingleRoom extends Room {
    private static $bedNumber = 1;
    private static $extras = ['TV', 'air-conditioner'];

    public function __construct($roomNumber, $price) {
        parent::__construct(
            RoomType::Standard,
            true,
            false,
            SingleRoom::$bedNumber,
            $roomNumber,
            SingleRoom::$extras,
            $price);
    }
}