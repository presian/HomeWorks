<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<title></title>
		<link rel="stylesheet" href="">
	</head>
	<body>
		<form action="_7_GetFormData.php" method="get">
			<input type="text" name="name"placeholder="Name..."><br>
			<input type="text" name="age"placeholder = "Age..."><br>
                        <input type="radio" name="gender" id="male" value="Male"><label for="male">Male</label><br>
                        <input type="radio" name="gender" id="female"value="Female"><label for="female">Female</label><br>
			<input type="submit">
		</form>
	</body>
</html>
<?php
	if ((isset($_GET['name']))&&(isset($_GET['age']))&&(isset($_GET['gender']))) {
		$name = $_GET['name'];
		$age = $_GET['age'];
		$gender = $_GET['gender'];
		echo "My mane is ".$name.". I am ".$age." years old. I am ".$gender;
	}
?>

