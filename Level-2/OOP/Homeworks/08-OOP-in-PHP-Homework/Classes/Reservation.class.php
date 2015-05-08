<?php

namespace Classes;


class Reservation {
    private $startDate;
    private $endDate;
    private $guest;

    public function __construct($startDate, $endDate, $guest) {
        $this->setStartDate($startDate);
        $this->setEndDate($endDate);
        $this->setGuest($guest);
    }

    public function getStartDate() {
        return $this->startDate;
    }

    public function setStartDate($startDate) {
        if (strtotime($startDate) < strtotime('now') || !$this->validateDate($startDate)) {
            throw new \InvalidArgumentException("Invalid start date of the reservation.");
        }

        $this->startDate = strtotime($startDate);
    }

    public function getEndDate() {
        return $this->endDate;
    }

    public function setEndDate($endDate) {
        if (strtotime($endDate) <= $this->startDate || !$this->validateDate($endDate)) {
            throw new \InvalidArgumentException("Invalid end date of the reservation.");
        }

        $this->endDate = strtotime($endDate);
    }

    private function validateDate($date, $format = 'd-m-Y') {

        $d = \DateTime::createFromFormat($format, $date);
        return $d && $d->format($format) == $date;
    }

    public function getGuest() {
        return $this->guest;
    }

    public function setGuest(Guest $guest) {
        $this->guest = $guest;
    }

    public function __toString() {
        $result =
            '<strong>' . $this->getGuest() . '</strong> ' .
            'from <time>' . date('d-m-Y', $this->getStartDate()) . '</time> ' .
            'to <time>' . date('d-m-Y', $this->getEndDate()) . '</time>';
        return $result;
    }
}