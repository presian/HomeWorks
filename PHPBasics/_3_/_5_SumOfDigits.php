<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title>_5_SumOfDigit</title>
            <link rel = "stylesheet" href = "styles/_5_SumOfDigits.css">
    </head>
    <body>
        <div id="window">
            <form>
                <label for="input">Input string</label>
                <input type="text" id="input" name="input" autofocus>
                <input type="submit" name="submit">
            </form>
        </div>
        <div id="result">            
<?php
if ((isset($_GET['input']))&&(isset($_GET['submit']))) {
    $inputStr = $_GET['input'];
    $nums = explode(",", $inputStr);
    $out = array();
    for ($a = 0; $a < count($nums); $a++) {
        if (is_numeric($nums[$a])) {
            $nums[$a] = trim($nums[$a]);
            $chars=  str_split($nums[$a]);
            $sum = 0;
            for ($b = 0; $b < count($chars); $b++) {
                $sum =  $sum + $chars[$b];
            }
            $out[$nums[$a]]=$sum;
        } else {
            $out[$nums[$a]]="I cannot sum that";
        }   
    }
    echo "<table>";
    foreach ($out as $key => $value) {
        echo "<tr><td>$key</td><td>$value</td></tr>";
    }
    //var_dump($out);
    echo "</table>";
}?>       
        </div>
    </body>
</html>
