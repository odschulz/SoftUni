<?php

namespace Classes;


class Room implements iReservable {

    private $roomType;
    private $hasRestroom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $extras = [];
    private $price;
    private  $reservations = [];
    
    public function __construct($roomType, $hasRestroom, $hasBalcony, $bedCount, $roomNumber, $extras, $price) {
        $this->roomType = $roomType;
        $this->hasRestroom = $hasRestroom;
        $this->hasBalcony = $hasBalcony;
        $this->bedCount = $bedCount;
        $this->setRoomNumber($roomNumber);
        $this->extras = $extras;
        $this->setPrice($price);
    }


    public function getRoomType() {
        if ($this->roomType == 1) {
            return 'Standard';
        } else if ($this->roomType == 2) {
            return 'Gold';
        } else {
            return 'Diamond';
        }
    }

    public function getHasRestroom() {
        return $this->hasRestroom;
    }

    public function getHasBalcony() {
        return $this->hasBalcony;
    }

    public function getBedCount() {
        return $this->bedCount;
    }

    public function getRoomNumber() {
        return $this->roomNumber;
    }

    private function setRoomNumber($roomNumber) {
        // Assuming the hotel has 3 floors
        if (!is_numeric($roomNumber) || $roomNumber < 100 || $roomNumber >= 400) {
            throw new \InvalidArgumentException(
                "Invalid room number. Rooms must have a number between 1 and 100.");
        }

        $this->roomNumber = $roomNumber;
    }


    public function getExtras() {
        return $this->extras;
    }

    public function getPrice() {
        return $this->price;
    }

    public function setPrice($price) {
        if ($price <= 0) {
            throw new \InvalidArgumentException(
                "Invalid price. Room price must be a positive number.");
        }

        $this->price = $price;
    }

    public function getReservations() {
        return $this->reservations;
    }

    public function addReservation(Reservation $r) {
        if ($this->isBooked($r->getStartDate(), $r->getEndDate())) {
            throw new EReservationException();
        }

        // create a unique ID for each reservation by hashing it, so that it can easily be removed
        // Works here, however in general it would probably be better to use something like
        // the native Data Structure for Object collections - SplObjectStorage.
        $reservationID = spl_object_hash($r);
        $this->reservations[$reservationID] = $r;
    }

    public function removeReservation(Reservation $reservation) {
        $reservationID = spl_object_hash($reservation);
        if (array_key_exists($reservationID, $this->getReservations())) {
            unset($this->reservations[$reservationID]);
        } else {
            throw new \InvalidArgumentException("The reservation doesn't exist for this room.");
        }
    }

    public function isBooked($startDate, $endDate) {
        foreach ($this->getReservations() as $existingReservation) {
            if ($startDate >= $existingReservation->getStartDate()
                && $startDate < $existingReservation->getEndDate()) {
                return true;
            } else if ($endDate > $existingReservation->getStartDate()
                && $endDate <= $existingReservation->getEndDate()) {
                return true;
            }
        }


        return false;
    }

    public function __toString() {
        $result =
            'Room Number: ' . $this->getRoomNumber() . '<br>' .
            'Room Type: ' . $this->getRoomType() . '<br>' .
            'Restroom: ' . ($this->getHasRestroom() ? "Yes" : "No") . '<br>' .
            'Balcony: ' . ($this->getHasBalcony() ? "Yes" : "No") . '<br>' .
            'Bed Count: ' . $this->getBedCount() . '<br>' .
            'Extras: ' . implode(', ', $this->getExtras()) . '<br>' .
            'Reservations count: ' . count($this->getReservations()) . '<br>' .
            'Price: ' . $this->getPrice() . '<br>';
        return $result;
    }
 }