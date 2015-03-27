<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Calculate Interest</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

	<form action="" method="post">
		<div>
			<label for="amount">Enter Amount</label>
			<input type="text" name="amount" id="amount" required="required">
		</div>

		<div>
			<input type="radio" name="currency" id="usd" value="$" required="required">
			<label for="usd">USD</label>
			<input type="radio" name="currency" id="eur" value="&euro;" required="required">
			<label for="eur">EUR</label>
			<input type="radio" name="currency" id="bgn" value="BGN" required="required">
			<label for="bgn">BGN</label>
		</div>
		<div>	
			<label for="cia">Compound Interest Amount</label>
			<input type="text" name="cia" id="cia" required="required">
		</div>

		<div>
			<select name="period">
				<option value="6">6 Months</option>
	  			<option value="12">1 Year</option>
	  			<option value="24">2 Years</option>
	  			<option value="60">5 Years</option>
			</select>
			<input type="submit" value="Calculate">
		</div>
	</form>

	<?php 
	if (isset($_POST['amount'], $_POST['currency'], $_POST['cia'], $_POST['period'])):
		if (filter_var($_POST['amount'], FILTER_VALIDATE_FLOAT) && filter_var($_POST['cia'], FILTER_VALIDATE_FLOAT)):
			$amount = (float)$_POST['amount'];
			$currency = $_POST['currency'];
			$cia = (float)$_POST['cia'];
			$period = (int)$_POST['period'];
			$result = $amount;
			$monthly = ($cia / 12 + 100) / 100;
			for ($i=1; $i <= $period; $i++) { 
				$result = $result * $monthly;
			}
		?>
		<p><?php echo (htmlspecialchars($currency) . " " . round($result, 2)); ?></p>
		<?php else: ?>
			<p><?php echo "Invalid Input"; ?></p>
		<?php endif; ?>
	<?php endif; ?>
</body>
</html>