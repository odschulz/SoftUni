<?php
function getSundays($date)
{
    return new DatePeriod(
        new DateTime("first sunday of $date"),
        DateInterval::createFromDateString('next sunday'),
        new DateTime("last day of $date")
    );
}

$currentDate = date('Y-m');
foreach (getSundays($currentDate) as $sunday) {
    echo $sunday->format("jS F, Y") . "<br>";
}

?>