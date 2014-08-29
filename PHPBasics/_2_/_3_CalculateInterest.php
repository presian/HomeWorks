
<!DOCTYPE html>
<html>
    <head>
            <meta charset = "utf-8">
            <meta http-equiv = "X-UA-Compatible" content = "IE=edge">
            <title>_3_CalculateInterest</title>
            <link rel = "stylesheet" href = "styles/_3_CalculateInterest.css">
    </head>
    <body>
        <div id="window">
            <form action="_3_CalculateInterest.php" method="POST">
                <label for="amount">Enter Amount</label>
                <input type="text" id="amount" name="amount"><br>
                <input type="radio" name="currency" id="usd" value="1"><label for="usd"> USD</label>
                <input type="radio" name="currency" id="eur" value="2"><label for="eur"> EUR</label>
                <input type="radio" name="currency" id="bgn" value="3"><label for="bgn"> BGN</label><br>
                <label for="interest">Compound Interest Amount</label>
                <input type="text" id="interest" name="interest"><br>
                <select name="time">
                    <option value="1" selected>6 Months</option>
                    <option value="2">1 Year</option>
                    <option value="3">2 Years</option>
                    <option value="4">5 Years</option>
                </select>
                <input type="submit" name="submit" value="Calculate">
<?php 
if ((isset($_POST['submit']))&&(isset($_POST['amount']))&&(isset($_POST['interest']))&&(isset($_POST['time']))) {
    $amount = $_POST['amount'];
    $currency = $_POST['currency'];
    switch ($currency) {
        case '1': 
            $currency="$";
            break;
        case '2':
            $currency="\xE2\x82\xAc";
            break;
        case '3':
            $currency='';
            break;
        default: '';
            break;
    }
    $interest = $_POST['interest'] / 100;
    $time = $_POST['time'];
    switch ($time) {
        case '1':
            $time = 0.5;
            break;
        case '2':
            $time = 1;
            break;
        case '3':
            $time = 2;
            break;
        case '4':
            $time = 5;
            break;
        default:
            break;
    }  
$result = $amount*pow((1+($interest/12)),(12*$time));
echo $currency.round($result, 2);
}
?>
            </form>
        </div>
    </body>
</html>

