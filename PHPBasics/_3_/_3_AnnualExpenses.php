<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title>_3_AnnualExpenses</title>
            <link rel = "stylesheet" href = "styles/_3_AnnualExpenses.css">
    </head>
    <body>
        <div id="window">
            <form action="_3_AnnualExpenses.php" method="GET">
                <label for="period">Enter number of years:</label>
                <input type="text" id="period" name="period">
                <input type="submit" value="Show costs" name="submit">
            </form>
        </div>
        <div id="result">
<?php if ((isset($_GET['period']))&&(isset($_GET['submit']))) {
     echo '
            <table>
                <thead>
                    <tr>
                        <th>
                            Year
                        </th>
                         <th>
                            January
                        </th>
                         <th>
                            February
                        </th>
                         <th>
                            March
                        </th>
                         <th>
                            April
                        </th>
                         <th>
                            May
                        </th>
                         <th>
                            June
                        </th>
                         <th>
                            July
                        </th>
                         <th>
                            August
                        </th>
                         <th>
                            September
                        </th>
                         <th>
                            October
                        </th>
                         <th>
                            November
                        </th>
                         <th>
                            December
                        </th>
                         <th>
                            Total
                        </th>
                    </tr>
                </thead>
                <tbody>';
$num = $_GET['period'];
    for ($a = 0; $a < $num; $a++) {
        $year = 2014-$a;
        $sum = 0;
        echo "<tr><td>$year</td>";
        for ($b = 0; $b < 12; $b++) {
            $expenses=rand(0, 999);
            $sum = $sum+$expenses;
            echo "<td>$expenses</td>";
        }
       echo "<td>$sum</td></tr>";
    }
}?>                      
                    
                </tbody>
            </table>
        </div>
    </body>
</html>
