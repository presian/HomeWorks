<!DOCTYPE html>
<html>
    <head>
        <meta charset = "utf-8">
        <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
        <title></title>
        <link rel = "stylesheet" href = "styles/_3_SidebarBuilder.css">
    </head>
    <body>
        <div id="window">
            <form action="_3_SidebarBuilder.php" method="GET">
                <label for="categories">Categories:</label>
                <input type="text" name="categories" id="categories"><br>
                <label for="tags">Tags:</label>
                <input type="text" name="tags" id="tags"><br>
                <label for="months">Months:</label>
                <input type="text" name="months" id="months"><br>
                <input type="submit" value="Generate" name="submit">
            </form>
        </div>
        <div id="result">
<?php 
    if (isset($_GET['submit'])&&isset($_GET['categories'])&&isset($_GET['tags'])&&isset($_GET['months'])){
        $categories = preg_split("/, /", $_GET['categories'], NULL, PREG_SPLIT_NO_EMPTY);
        $tags = preg_split("/, /", $_GET['tags'], NULL, PREG_SPLIT_NO_EMPTY);
        $months = preg_split("/, /", $_GET['months'], NULL, PREG_SPLIT_NO_EMPTY);
        echo "<aside><h3>Categories</h3><ul>".sideBarCreator($categories);
        echo "<aside><h3>Tags</h3><ul>".sideBarCreator($tags);
        echo "<aside><h3>Months</h3><ul>".sideBarCreator($months);
        
    }
    function sideBarCreator($a) {  
        $out= '';
        foreach ($a as $value) {
            $out = $out.'<li><a href="#">'."$value</a></li>";
        }
        $out = $out."</ul></aside>";
        return $out;
}
?> 
        </div>
    </body>
</html>


