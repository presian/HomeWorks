<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title>_4_PrimesInRange</title>
            <link rel = "stylesheet" href = "styles/_4_PrimesInRange.css">
    </head>
    <body>
        <div id="window">
            <form action="_4_PrimesInRange.php" method="GET">
                <label for="start">Starting index:</label>
                <input type="text" id="start" name="start">
                <label for="end">End:</label>
                <input type="text" name="end" id="end">
                <input type="submit" name="submit">
            </form>
        </div>
        <div id="result">
<?php 
if ((isset($_GET['start']))&&(isset($_GET['end']))&&(isset($_GET['submit']))) {
    $start = $_GET['start'];
    $end = $_GET['end'];
    $counter = 0;
    $prime = array();
    for ($a = $start; $a <=$end; $a++) {
        for ($b = 2; $b < $a; $b++) {
            if ($a%$b==0) {
                $counter++;
            }
        }
        if ($counter == 0) {
            if ($a==$end) {
                echo "<b>$a</b>";
            } else {
                echo "<b>$a</b>,";
            } 
        } else{
            if ($a==$end) {
                echo $a;
            } else {
                echo "$a,";
            }
        } 
        $counter = 0;
    }
}
?>
        </div>
    </body>
</html>

