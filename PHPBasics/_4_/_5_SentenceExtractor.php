<!DOCTYPE html>
<html>
    <head>
        <meta charset = "utf-8">
        <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
        <title>_5_SentenceExtractor</title>
        <link rel = "stylesheet" href = "styles/_5_SentenceExtractor.css">
    </head>
    <body>
        <div id="window">
            <form action="_5_SentenceExtractor.php" method="GET">
                <textarea name="text"></textarea><br>
                <input type="text" name="word" id="word">
                <input type="submit" name="submit">
            </form>
        </div>
        <div id="result">
            <?php
            if (isset($_GET['submit']) && isset($_GET['word']) && isset($_GET['text'])) {
                $in = preg_split('/ /', $_GET['text'], NULL, PREG_SPLIT_NO_EMPTY);
                $word = $_GET['word'];
                $temp = array();
                for ($a = 0; $a < count($in); $a++) {
                    $temp[] = $in[$a];
                    $current = $in[$a];
                    if (($current[strlen($current) - 1] == '!') || ($current[strlen($current) - 1] == '?') || ($current[strlen($current) - 1] == '.')) {
                        $str = implode(' ', $temp);
                        for ($b = 0; $b < count($temp); $b++) {
                            if ($temp[$b] == $word) {
                                echo $str . "<br>";
                            }
                        }
                        $temp = array();
                    }
                }
            }
            ?>
        </div>

    </body>
</html>
