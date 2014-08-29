<?php

function noRepeat($var) {
    if ($var<102) {
        echo "no";
    } else if ($var >999) {
                for ($a = 102; $a <= 999; $a++) {
            $dig = (string)$a;
            if (($dig[0]!=$dig[1])&&($dig[1]!=$dig[2])&&($dig[0]!=$dig[2])) {
                echo $a;
                echo ", ";
            }
       }
    } else {
        for ($a = 102; $a <= $var; $a++) {
            $dig = (string)$a;
            if (($dig[0]!=$dig[1])&&($dig[1]!=$dig[2])&&($dig[0]!=$dig[2])) {
                echo $a;
                echo ", ";
            }
       }
    }
    echo "<br/>";
}
noRepeat(1234);
noRepeat(145);
noRepeat(15);
noRepeat(247);

