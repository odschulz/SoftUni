<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Primes in Range</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<form action="" method="post">
		<label for="start">Starting Index: </label>
		<input type="text" name="start" id="start">
		<label for="end">End: </label>
		<input type="text" name="end" id="end">
		<input type="submit">
	</form>
	<?php 
	if (isset($_POST['start']) && ctype_digit($_POST['start']) && 
		isset($_POST['end']) && ctype_digit($_POST['end']) && $_POST['start'] < $_POST['end']) :

		$start = $_POST['start'];
		$end = $_POST['end'];
		$numsList = [];
		for ($i = $start; $i <= $end; $i++) { 
			if (isPrime($i)) {
				$numsList[] = "<span class=\"prime\">{$i}</span>";
			} else {
				$numsList[] = $i;
			}
		}
		$outputNums = implode(', ', $numsList);
	?>
	<div><?php echo $outputNums ?></div>
	<?php endif; ?>
	
</section>

<?php
function isPrime($number)
{
	if ($number < 2) {
		return false;
	}
	for ($i = 2; $i <= sqrt($number); $i++) {
		if ($number % $i == 0) {
			return false;
		}
	}
	return true;
}
?>
    
</body>
</html>