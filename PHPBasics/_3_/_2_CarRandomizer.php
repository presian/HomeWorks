
<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title></title>
            <link rel = "stylesheet" href = "styles/_2_CarRandomizer.css">
    </head>
    <body>
        <div id="window">
            <form action="_2_CarRandomizer.php" method="GET">
                <input type="text" name="cars">
                <input type="submit" value="Show results" name="submit">
            </form>
        </div>
 
<?php 
if ((isset($_GET['submit']))&&(isset($_GET['cars']))) {
    $input = $_GET['cars'];
    $cars = explode(", ",$input);
    $colors = array('yellow', 'black', 'red', 'blue', 'gray');?>
               <div id="result">
            <table>
                <thead>
                    <tr>
                        <th>
                            Cars
                        </th>
                        <th>
                            Color
                        </th>
                        <th>
                            Count
                        </th>
                    </tr>
                </thead>
                <tbody>
 <?php   
    for ($a = 0; $a < count($cars); $a++) {
        $randColor = $colors[rand(0, count($colors)-1)];
        $quantity = rand(0, 5);
        echo "<tr><td>$cars[$a]</td><td>$randColor</td><td>$quantity</td></tr>";
    }
}?>
                </tbody>
            </table>
        </div>
    </body>
</html>

