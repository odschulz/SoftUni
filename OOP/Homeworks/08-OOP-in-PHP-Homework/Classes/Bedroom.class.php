<?php

namespace Classes;


class Bedroom extends Room {
    private static $bedNumber = 2;
    private static $extras = ['TV', 'air-conditioner', 'refrigerator', 'mini-bar', 'bathtub'];

    public function __construct($roomNumber, $price) {
        parent::__construct(
            RoomType::Gold,
            true,
            true,
            Bedroom::$bedNumber,
            $roomNumber,
            Bedroom::$extras,
            $price);
    }
}