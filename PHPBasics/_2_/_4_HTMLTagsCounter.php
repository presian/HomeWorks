
<?php session_start();?>
<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title>_4_HTMLTagsCounter</title>
            <link rel = "stylesheet" href = "styles/_4_HTMLTagsCounter.css">
    </head>
    <body>
        <div id="window">
            <form action="_4_HTMLTagsCounter.php" method="POST">
                <label for="input">Enter HTML tags:</label><br>
                <input name="input" id="input" autofocus>
                <input type="submit" name="submit">
            </form>
<?php
//=======================================            
//      all HTML tags in array
//=======================================
$tags = array("a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "blockquote", "body", "br", "button", "canvas", "caption",
"cite", "code", "col", "colgroup", "command", "datalist", "dd", "del", "details", "dfn", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption", "figure",
"footer", "form", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header", "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label",
"legend", "li", "link", "map", "mark", "menu", "meta", "meter", "nav", "noscript", "object", "ol", "optgroup", "option", "output", "p", "param", "pre", "progress",
"q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source", "span", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td",
"textarea", "tfoot", "th", "thead", "time", "title", "tr", "track", "u", "ul", "var", "video", "wbr");
//=======================================
//              logic
//=======================================
if (!isset($_SESSION["score"])&& !isset($_SESSION["remTags"])) {
    $_SESSION["score"] = 0;
    $_SESSION["remTags"] = $tags;
}
//if (!isset($_SESSION["score"]) || !isset($_SESSION["tagsLeft"])) {
//        $_SESSION["score"] = 0;
//        $_SESSION["tagsLeft"] = $tags;
//    }
if((isset($_POST['submit']))&&(isset($_POST['input']))) {
 $_SESSION['input'] = $_POST['input'];
 $currentTag = mb_strtolower($_POST['input']);
 $key=array_search($currentTag, $_SESSION['remTags']);
 if ($key === false) {
    $rem = count($_SESSION['remTags']);
    echo "Invalid HTML tag!<br>Score: {$_SESSION['score']}<br>Remeaning tags: $rem"; 
 }  else {
    $_SESSION['score']++;
    unset($_SESSION['remTags'][$key]);
    array_values($_SESSION['remTags']);
    $remCount = count($_SESSION['remTags']);
    if ($remCount>0) {
        echo "Valid HTML tag!<br>Score: {$_SESSION['score']}<br>Remeaning tags: $remCount";
    } else{
        echo "Valid HTML tag!<br>Score: {$_SESSION['score']}<br>No more tags!";
        session_destroy();
    } 
 }
}       
?>
        </div>


    </body>
</html>