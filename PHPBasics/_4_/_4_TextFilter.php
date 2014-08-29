<!DOCTYPE html>
<html>
    <head>
        <meta charset = "utf-8">
        <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
        <title>_4_TextFilter</title>
        <link rel = "stylesheet" href = "styles/_4_TextFilter.css">
    </head>
    <body>
        <div id="window">
            <form action="_4_TextFilter.php" method="GET">
                <textarea name="input"></textarea><br>
                <input type="text" id="banlist" name="banlist"><br>
                <input type="submit" id="submit" name="submit" value="Filtrate">
            </form>
        </div>
        <div id="result">
            <?php
            if (isset($_GET['submit']) && isset($_GET['banlist']) && isset($_GET['input'])) {
                $banlist = preg_split("/[^A-Za-z]/", $_GET['banlist'], NULL, PREG_SPLIT_NO_EMPTY);
                $in = $_GET['input'];
                for ($a = 0; $a < count($banlist); $a++) {
                    $arr = array_fill(0, strlen($banlist[$a]), '*');
                    $aster = implode('', $arr);
                    $in = str_replace($banlist[$a], $aster, $in);
                }
                echo $in;
            }
            ?>            
        </div>
    </body>
</html>

