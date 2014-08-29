<!DOCTYPE html>
<html>
    <head>
        <meta charset = "utf-8">
        <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
        <title></title>
        <link rel = "stylesheet" href = "styles/_1_WordMapper.css">
    </head>
    <body>
        <div id="window">
            <form action="_1_WordMapper.php" method="GET">
            <textarea name="input">
                
            </textarea><br>
            <input type="submit" name="submit" value="Count words">
        </form>
        </div>
        <div id="result">
<?php 
if (isset($_GET['submit']) && isset($_GET['input'])) {
    $str = strtolower($_GET['input']);
    echo '<table><tbody><tr><td colspan="2">RESULT</td></tr>';
    $arr = preg_split("/[^A-Za-z]+/", $str, NULL, PREG_SPLIT_NO_EMPTY);
    $temp = array_count_values($arr);
    foreach ($temp as $key => $value) {
        echo "<tr><td>$key</td><td>$value</td></tr>";
    }
    echo '</tbody></table>';
}
?>
        </div>

                    

    </body>
</html>


