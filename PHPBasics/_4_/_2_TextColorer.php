<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title></title>
            <link rel = "stylesheet" href = "styles/_2_TextColorer.css">
    </head>
    <body>
        <div id="window">
            <form action="_2_TextColorer.php" method="GET">
                <textarea name="input"></textarea><br>
                <input type="submit" name="submit" value="Color text">
            </form>            
        </div>
        <div id="result">
<?php 
if (isset($_GET['input'])&&isset($_GET['submit'])) {
    $in = $_GET['input'];
    $arr = preg_split("/[^A-Za-z]/", $in);
    $arr = implode($arr);
    $arr = preg_split("//", $arr,NULL,PREG_SPLIT_NO_EMPTY);
    for ($a = 0; $a < count($arr); $a++) {
        $out='';
        if ($a<  count($arr)-1) {
            $out=$arr[$a].' ';
        }
        if (ord($arr[$a])%2==0) {
            echo '<span style="color:blue;">'."$out</span>"; 
        } else {
            echo '<span style="color:red;">'."$out</span>";
        }
    }
    //var_dump($arr);
    
}
?>          
        </div>

    </body>
</html>
