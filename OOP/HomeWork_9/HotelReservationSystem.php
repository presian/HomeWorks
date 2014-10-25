<?php
function __autoload($className) {
    include_once("./" . $className . ".class.php");
}

$rooms[201] = new SingleRoom(201, 40);
$rooms[305] = new SingleRoom(305, 60);
$rooms[401] = new SingleRoom(401, 40);
$rooms[412] = new Bedroom(412, 70);
$rooms[302] = new Bedroom(302, 80);
$rooms[202] = new Bedroom(202, 70);
$rooms[410] = new Bedroom(410, 80);
$rooms[501] = new Apartment(250, 200);
$rooms[502] = new Apartment(502, 300);
$rooms[601] = new Apartment(601, 350);

//
//$apAndBedAbove250 = array_filter($rooms,function ($room){
//    return (get_class($room) == "Bedroom" || get_class($room) == "Apartment")&& $room->getPrice()<=250;
//});
//echo(implode("\n======================================\n",$apAndBedAbove250));
//
//$withBalcony = array_filter($rooms, function($room){
//    return $room->getHasBalcony()=== true;
//});
//
//echo "\n++++++++++++++++++++++++++++++++\n";
//echo (implode("\n======================================\n",$withBalcony));

function getNumbersOfRoomsWithBathtub($rooms)
{
    $withBathtub = array_filter($rooms, function ($room) {
        return in_array("Bathtube", $room->getExtras());
    });
    $roomNumbers = [];
    foreach ($rooms as $room) {
        $roomNumbers[] = $room->getRoomNumber();
    }
    return $roomNumbers;
}

$roomNumbers = getNumbersOfRoomsWithBathtub($rooms);
echo(implode(", ",$roomNumbers));

