<?php

namespace Classes;


class BookingManager {
    public static function bookRoom(Room $room, Reservation $reservation) {
        try {
            $room->addReservation($reservation);
            $successMessage =
                'Room <strong>' . $room->getRoomNumber() . '</strong> ' .
                'successfully booked for ' . $reservation;
            echo $successMessage;
        } catch (Exception $e) {
            echo "$e";
        }
    }

    public static function unbookRoom(Room $room, Reservation $reservation) {
        try {
            $room->removeReservation($reservation);
            $successMessage =
                'Successfully removed reservation for Room <strong>' . $room->getRoomNumber() . '</strong> ' .
                ' for ' . $reservation;
            echo $successMessage;
        } catch (Exception $e) {
            echo "$e";
        }
        
    }
}