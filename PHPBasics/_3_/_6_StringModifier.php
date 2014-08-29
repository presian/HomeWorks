<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title></title>
            <link rel = "stylesheet" href = "">
    </head>
    <body>
        <div id="window">
            <form action="_6_StringModifier.php" method="GET">
                <input type="text" id="input" name="input">
                <input type="radio" name="modifier" id="palindrome" value="palindrome">
                <label for="palindrome">Check Palindrome</label>
                <input type="radio" name="modifier" id="reverse" value="reverse">
                <label for="reverse">Reverse String</label>
                <input type="radio" name="modifier" id="split" value="split">
                <label for="split">Split</label>
                <input type="radio" name="modifier" id="hash" value="hash">
                <label for="hash">Hash String</label>
                <input type="radio" name="modifier" id="shuffle" value="shuffle">
                <label for="shuffle">Shuffle String</label>                
                <input type="submit" id="submit" name="submit" value="Submit">
            </form>
        </div>
        <div id="result">
<?php 
if ((isset($_GET['submit']))&&(isset($_GET['modifier']))&&(isset($_GET['input']))) {
    $in = $_GET['input'];
    $out = '';
    switch ($_GET['modifier']) {
        case 'palindrome':
            $temp = strrev($in);
            if ($in==$temp) {
                $out=$temp;
            } else{
                $out = "$in is not a palindrome!";
            }
            break;
        case 'reverse':
            $out = strrev($in);
            break;
        case 'split':
            $temp = preg_split("/[^A-Za-z]/",$in);
            $temp = implode($temp);
            $temp = preg_split("//", $temp,NULL,PREG_SPLIT_NO_EMPTY);
            for ($a = 0; $a < count($temp); $a++) {
                if ($a < count($temp)-1) {
                    $out=$out.$temp[$a];
                    $out= $out.' ';  
                } else {
                    $out=$out.$temp[$a];
                }    
            }
            break;
        case 'hash':
            $out = crypt($in);

            break;
        case 'shuffle':
            $out = str_shuffle($in);
            break;
        default:
            break;
    }
    echo $out;
}
?>            
        </div>
    </body>
</html>

