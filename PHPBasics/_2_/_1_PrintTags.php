
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
            <form action="_1_PrintTags.php" method="POST">
                <label>Enter Tags</label><br>
                <input type="text" name="field"><br>
                <input type="submit" name="submit">
            </form>
<?php
if (isset($_POST['submit'])) {
    $str = $_POST['field'];
    $arr = explode(", ", $str);
    $length = count($arr);
    for ($index = 0; $index < $length; $index++) {
        if ($arr[$index]!='') {
            echo key($arr)." : $arr[$index]<br>";        
            next($arr);
        }       
    }
}?>
        </div>        
    </body>
</html>

