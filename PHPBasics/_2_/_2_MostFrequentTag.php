
<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title>_PrintTags_</title>
            <link rel = "stylesheet" href = "styles/_1_.css">
    </head>
    <body>
        <div id="window">
            <form action="_2_MostFrequentTag.php" method="POST">
                <label>Enter Tags</label><br>
                <input type="text" name="field"><br>
                <input type="submit" name="submit">
            </form>
<?php
if (isset($_POST['submit'])) {
    $str = $_POST['field'];
    $arr = explode(", ", $str);
    $length = count($arr);
    $counter = 0;
    $array = array();
    if ($arr[0]!='') {
           for ($a = 0; $a < $length; $a++) {
        for ($b = 0; $b < $length; $b++) {
            if ($arr[$a]===$arr[$b]) {
                $counter++;
            }
        }
        $array[$arr[$a]] = $counter;
        $counter=0;
    }
    arsort($array);
    $l = count($array);
    for ($c = 0; $c < $l; $c++) {
        echo key($array)." : ".current($array)."<br>";
        next($array);
    }
    reset($array);
    echo "<br>Most Frequent Tag is: ".key($array); 
    }

}?>
        </div>
        
    </body>
</html>
