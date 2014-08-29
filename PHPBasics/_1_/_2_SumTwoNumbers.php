<?php

function roundedSum($a, $b) {
    $result = $a + $b;
    echo "\$firstNumber + \$secondNumber = $a + $b = " . number_format($result,2,'.','')."<br />";
}
roundedSum(2, 5);
roundedSum(1.567808, 0.356);
roundedSum(1234.5678, 333);