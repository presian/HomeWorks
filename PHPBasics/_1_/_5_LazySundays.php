<?php

$firstSunday = strtotime("first Sunday of this month");
$lastDayOfMonth = strtotime("last day of this month");
$week = 7*24*60*60;

for ($a = $firstSunday; $a < $lastDayOfMonth; $a+=$week) {
   $out = date('jS F, Y',$a)."<br/>";
   echo $out;
}
