<?php

namespace Classes;


class Apartment extends Room {
    private static $bedNumber = 4;
    private static $extras = [
        'TV',
        'air-conditioner',
        'refrigerator',
        'kitchen box',
        'mini-bar',
        'bathtub',
        'free Wi-fi'
    ];

    public function __construct($roomNumber, $price) {
        parent::__construct(
            RoomType::Diamond,
            true,
            true,
            Apartment::$bedNumber,
            $roomNumber,
            Apartment::$extras,
            $price);
    }
}