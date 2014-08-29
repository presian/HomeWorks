<!DOCTYPE html>
<html>
    <head>
        <meta charset = "utf-8">
        <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
        <title>_6_URLReplacer</title>
        <link rel = "stylesheet" href = "styles/_6_URLReplacer.css">
    </head>
    <body>
        <div id="window">
            <form action="_6_URLReplacer.php" method="GET">
                <textarea name="text"></textarea><br>
                <input type="submit" name="submit">
            </form>
        </div>
        <div id="result">
            <?php
            if (isset($_GET['submit']) && isset($_GET['text'])) {
                $in = $_GET['text'];
                $out = str_replace('</a>', '[/URL]', $in);
//                $out = str_replace('<a href="', '[URL=', $in);
//                $out = str_replace('">', ']', $out);
                $out = preg_replace('/<a href="(.*?)">/', '[URL=\1]', $out);
                echo $out;
            }
            ?>
        </div>
    </body>
</html>
