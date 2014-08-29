<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<title></title>
                <link rel="stylesheet" href="styles/_1_SquareRootSum.css">
	</head>
	<body>
		<div id="window">
			<table>
                            <tbody>
<?php	
$square = 0;
$sum = 0;
$out = '';
    for ($a=0; $a <= 100; $a++) { 
            if ($a%2==0) {
                $square = sqrt($a);
                $out = number_format($square, 2);
                $sum = $sum + $out;
                echo "<tr><td> $a </td><td> $out </td></tr>";
            }
    }
    echo "<tr><td><b>Total:</b></td><td> $sum </td></tr>";
?>			
                            </tbody>
			</table>
		</div>
	</body>
</html>
