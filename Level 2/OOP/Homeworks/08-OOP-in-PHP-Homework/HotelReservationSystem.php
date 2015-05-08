<?php

use Classes\Apartment;
use Classes\Bedroom;
use Classes\BookingManager;
use Classes\Guest;
use Classes\Reservation;
use Classes\Room;
use Classes\SingleRoom;

spl_autoload_register(function($class) {
    include $class . '.class.php';
});

date_default_timezone_set ('Europe/Sofia');

try {
    $hotelRooms = [
        101 => new SingleRoom(101, 80.00),
        102 => new SingleRoom(102, 75.00),
        103 => new SingleRoom(103, 75.00),
        104 => new SingleRoom(104, 80.00),
        201 => new Bedroom(201, 140.00),
        202 => new Bedroom(202, 145.00),
        203 => new Bedroom(203, 142.00),
        204 => new Bedroom(204, 140.00),
        205 => new Bedroom(205, 140.00),
        301 => new Apartment(301, 250.00),
        302 => new Apartment(302, 255.00),
        303 => new Apartment(303, 240.00),
        304 => new Apartment(304, 260.00)
    ];

    $guest1 = new Guest('Pesho', 'Peshev', '8001201020');
    $guest2 = new Guest('Ivan', 'Ivanov', '8501201020');
    $guest3 = new Guest('Marina', 'Marinova', '8711201020');

    $reservation1 = new Reservation('17-04-2015', '18-04-2015', $guest1);
    $reservation2 = new Reservation('16-04-2015', '18-04-2015', $guest2);
    $reservation3 = new Reservation('17-05-2015', '18-05-2015', $guest1);

    BookingManager::bookRoom($hotelRooms[101], $reservation1);
    echo "<br>";

    BookingManager::bookRoom($hotelRooms[102], $reservation2);
    echo "<br>";
    BookingManager::bookRoom($hotelRooms[301], $reservation3);
    echo "<br>";
    BookingManager::unbookRoom($hotelRooms[102], $reservation2);
    echo "<br>";
    echo "<hr>";

    echo "Bedrooms and apartments under 250:";
    echo "<br><br>";
    $bedroomsAndApartmentsUnder250 = array_filter($hotelRooms, function($room) {
        return (($room instanceof Bedroom || $room instanceof Apartment)
            && $room->getPrice() <= 250);
    });

    foreach ($bedroomsAndApartmentsUnder250 as $room) {
        echo $room;
        echo '<br>';
    }

    echo "<hr>";

    echo "Rooms with a balcony:";
    echo "<br><br>";
    $roomsWithBalcony = array_filter($hotelRooms, function($room) {
        return $room->getHasBalcony();
    });

    foreach ($roomsWithBalcony as $room) {
        echo $room;
        echo '<br>';
    }

    echo "<hr>";

    echo "Rooms with a bathtub:";
    echo "<br><br>";
    $roomsWithBathtub = array_filter($hotelRooms, function($room) {
        return in_array('bathtub', $room->getExtras(), FALSE);
    });

    foreach ($roomsWithBathtub as $room) {
        echo 'Room number: ' . $room->getRoomNumber();
        echo '<br>';
    }

    echo "<hr>";

    $startDateToCheck = '17-05-2015';
    $endDateToCheck = '18-05-2015';
    echo "Apartments without reservations from $startDateToCheck to $endDateToCheck:";
    echo "<br><br>";

    $apartments = array_filter($hotelRooms, function($room) {
        return $room instanceof Apartment;
    });


    function getApartmentsForPeriod($apartments, $startDate, $endDate) {
        $result = [];
        foreach ($apartments as $apartment) {
            if (!$apartment->isBooked(strtotime($startDate), strtotime($endDate))) {
                $result[] = $apartment;
            }
        }

        return $result;
    }

    $availableApartmentsForPeriod = getApartmentsForPeriod($apartments, $startDateToCheck, $endDateToCheck);

    foreach ($availableApartmentsForPeriod as $apartment) {
        echo $apartment;
        echo '<br>';
    }




} catch (Exception $e) {
    echo $e;
}
